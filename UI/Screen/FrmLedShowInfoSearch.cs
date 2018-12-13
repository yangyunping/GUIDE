using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.LED
{
    public partial class FrmScreenShowLogSearch : UserControl
    {
        BllLedShowInfo bllLedShowInfo = new BllLedShowInfo();
        public FrmScreenShowLogSearch()
        {
            InitializeComponent();
            DgvColumns();
            bntDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.预显示删除);
            btnReSetShow.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.重置预显示);
            cmbShowState.SelectedIndex = 0;
        }
        private void DgvColumns()
        {
            dgvTemShow.Columns.AddRange(
            new DataGridViewCheckBoxColumn { Name = @"勾选", DataPropertyName = @"勾选", HeaderText = @"", Width = 60 },
            new DataGridViewTextBoxColumn { Name = @"ID", DataPropertyName = @"ID", HeaderText = @"序号", Width = 60, ReadOnly = true },
            new DataGridViewTextBoxColumn { Name = @"ScreenId", DataPropertyName = @"ScreenId", HeaderText = @"屏幕编号", Width = 100 ,ReadOnly = true},
            new DataGridViewTextBoxColumn { Name = @"Tag", DataPropertyName = @"Tag", HeaderText = @"状态", Width = 80, ReadOnly = true },
            new DataGridViewTextBoxColumn { Name = @"AddressNum", DataPropertyName = @"AddressNum", HeaderText = @"地址码", Width = 100, ReadOnly = true },
            new DataGridViewTextBoxColumn { Name = @"BeginTime", DataPropertyName = @"BeginTime", HeaderText = @"开始时间", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"EndTime", DataPropertyName = @"EndTime", HeaderText = @"结束时间", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"Duration", DataPropertyName = @"Duration", HeaderText = @"循环时长", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"FontName", DataPropertyName = @"FontName", HeaderText = @"字体名称", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"FontSize", DataPropertyName = @"FontSize", HeaderText = @"字体大小", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"FontColor", DataPropertyName = @"FontColor", HeaderText = @"字体颜色", Width = 100, ReadOnly = true },
            new DataGridViewTextBoxColumn { Name = @"ShowStyle", DataPropertyName = @"ShowStyle", HeaderText = @"播放方式", Width = 100, ReadOnly = true },
            new DataGridViewTextBoxColumn { Name = @"Content", DataPropertyName = @"Content", HeaderText = @"显示内容", Width = 250 },
            new DataGridViewTextBoxColumn { Name = @"CreateDate", DataPropertyName = @"CreateDate", HeaderText = @"创建时间", Width = 100, ReadOnly = true },
            new DataGridViewButtonColumn { Name = @"修改", DataPropertyName = @"修改", HeaderText = @"", Width = 100 }
             );
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtShow = null;
            string sKey = string.Empty;
            string tag = string.Empty;
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                sKey += $"%{txtKey.Text}%";
            }
            if (cmbShowState.Text.Equals("显示成功"))
            {
                tag = "2";
            }
            else if (cmbShowState.Text.Equals("准备显示"))
            {
                tag = "0";
            }
            else if (cmbShowState.Text.Equals("显示失败"))
            {
                tag = "1";
            }
            dtShow = bllLedShowInfo.GetLayLEDShowInfos(tag, sKey);
            dgvTemShow.AutoGenerateColumns = false;
            dgvTemShow.DataSource = dtShow;
            chkAll.Checked = false;
            for (int i = 0; i < dgvTemShow.Rows.Count; i++)
            {
                dgvTemShow.Rows[i].Cells["勾选"].Value = 0;
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dgvTemShow.CurrentRow != null)
            {
                for (int i = 0; i < dgvTemShow.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvTemShow.Rows[i].Cells["勾选"].Value) == 1)
                    {
                        if (!bllLedShowInfo.DeleteLedShowInfo(Convert.ToInt32(dgvTemShow.Rows[i].Cells["ID"].Value)))
                        {
                            MessageBox.Show(dgvTemShow.CurrentRow.Cells["ScreenID"].ToString() + "删除失败！");
                            btnSearch_Click(null,null);
                            return;
                        }
                    }
                }
                MessageBox.Show("删除成功！");
                btnSearch_Click(null, null);
            }
        }

        private void dgvTemShow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1 && dgvTemShow.Columns[e.ColumnIndex].Name == "FontColor")
            {
                e.Value = PublicClass.ColorToText(dgvTemShow.Rows[e.RowIndex].Cells["FontColor"].Value.ToString());//颜色转换为汉语
            }
            else if (dgvTemShow.Columns[e.ColumnIndex].Name == "ShowStyle")
            {
                e.Value = PublicClass.AplayToText(Convert.ToInt32(dgvTemShow.Rows[e.RowIndex].Cells["ShowStyle"].Value));//播放方式转换汉语
            }
            else if (dgvTemShow.Columns[e.ColumnIndex].Name == "Tag")
            {
                e.Value = PublicClass.ConvertToState(Convert.ToInt32(dgvTemShow.Rows[e.RowIndex].Cells["Tag"].Value));
            }
            else if (dgvTemShow.Columns[e.ColumnIndex].Name == "修改")
            {
                e.Value = "修改";
            }
        }

        private void dgvTemShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTemShow.CurrentRow != null)
                {
                    if (dgvTemShow.Columns[e.ColumnIndex].Name == "修改")
                    {
                        if (dgvTemShow.CurrentRow.Cells["修改"].FormattedValue.ToString() == "修改")
                        {
                            LEDShowInfo lEDShowInfo = new LEDShowInfo();
                            lEDShowInfo.ID = Convert.ToInt32(dgvTemShow.CurrentRow.Cells["ID"].Value);
                            lEDShowInfo.BeginTime = dgvTemShow.CurrentRow.Cells["BeginTime"].Value.ToString();
                            lEDShowInfo.EndTime =dgvTemShow.CurrentRow.Cells["EndTime"].Value.ToString();
                            lEDShowInfo.Content = dgvTemShow.CurrentRow.Cells["Content"].Value.ToString();
                            lEDShowInfo.FontColor = dgvTemShow.CurrentRow.Cells["FontColor"].Value.ToString();
                            lEDShowInfo.FontName = dgvTemShow.CurrentRow.Cells["FontName"].Value.ToString();
                            lEDShowInfo.FontSize = Convert.ToInt32(dgvTemShow.CurrentRow.Cells["FontSize"].Value);
                            lEDShowInfo.Duration = Convert.ToInt32(dgvTemShow.CurrentRow.Cells["Duration"].Value);
                            if (bllLedShowInfo.UpdateLEDShowInfo(lEDShowInfo))
                            {
                                MessageBox.Show("修改成功！");
                                btnSearch_Click(null,null);
                            }
                            else
                            {
                                MessageBox.Show("修改失败!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                for (int i = 0; i < dgvTemShow.Rows.Count; i++)
                {
                    dgvTemShow.Rows[i].Cells["勾选"].Value = 1;
                }
            }
            else
            {
                for (int i = 0; i < dgvTemShow.Rows.Count; i++)
                {
                    dgvTemShow.Rows[i].Cells["勾选"].Value = 0;
                }
            }
        }

        private void btnReSetShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTemShow.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvTemShow.Rows[i].Cells["勾选"].Value) == 1)
                {
                    if (!bllLedShowInfo.UpdateLEDShowInfoState(Convert.ToInt32(dgvTemShow.Rows[i].Cells["ID"].Value),0))
                    {
                        MessageBox.Show("重置失败!");
                    }
                }
            }
            MessageBox.Show("重置成功！");
            btnSearch_Click(null, null);
        }
    }
}

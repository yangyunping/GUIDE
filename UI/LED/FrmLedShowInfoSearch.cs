using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.LED
{
    public partial class FrmLedShowInfoSearch : UserControl
    {
        BllLedShowInfo bllLedShowInfo = new BllLedShowInfo();
        public FrmLedShowInfoSearch()
        {
            InitializeComponent();
            DgvColumns();
            bntDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.预显示删除);
            cmbShowState.SelectedIndex = 0;
        }
        private void DgvColumns()
        {
            dgvTemShow.Columns.AddRange(
            new DataGridViewTextBoxColumn { Name = @"ID", HeaderText = @"序号", DataPropertyName = @"ID", Width = 60 },
            new DataGridViewTextBoxColumn { Name = @"ScreenId", DataPropertyName = @"ScreenId", HeaderText = @"屏幕编号",  Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"Tag", DataPropertyName = @"Tag", HeaderText = @"状态", Width = 80 },
            new DataGridViewTextBoxColumn { Name = @"AddressNum", DataPropertyName = @"AddressNum", HeaderText = @"控制卡地址码", Width = 140 },
            new DataGridViewTextBoxColumn { Name = @"BeginTime", DataPropertyName = @"BeginTime", HeaderText = @"开始时间", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"EndTime", DataPropertyName = @"EndTime", HeaderText = @"结束时间", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"FontName", DataPropertyName = @"FontName", HeaderText = @"字体名称", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"FontSize", DataPropertyName = @"FontSize", HeaderText = @"字体大小", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"FontColor", DataPropertyName = @"FontColor", HeaderText = @"字体颜色", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"ShowStyle", DataPropertyName = @"ShowStyle", HeaderText = @"播放方式", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"Content", DataPropertyName = @"Content", HeaderText = @"显示内容", Width = 500 },
            new DataGridViewTextBoxColumn { Name = @"CreateDate", DataPropertyName = @"CreateDate", HeaderText = @"最新时间", Width = 500 }
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
            if (cmbShowState.Text.Equals("全部"))
            {
                tag = "1','2";
            }
            else if (cmbShowState.Text.Equals("正在显示"))
            {
                tag = "2";
            }
            else if (cmbShowState.Text.Equals("准备显示"))
            {
                tag = "1";
            }
            dtShow = bllLedShowInfo.GetLayLEDShowInfos(tag, sKey);
            dgvTemShow.AutoGenerateColumns = false;
            dgvTemShow.DataSource = dtShow;
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dgvTemShow.CurrentRow != null)
            {
                if (bllLedShowInfo.DeleteLedShowInfo(Convert.ToInt32(dgvTemShow.CurrentRow.Cells["ID"].Value)))
                {
                    MessageBox.Show("删除成功！");
                    dgvTemShow.Rows.Remove(dgvTemShow.CurrentRow);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void dgvTemShow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex !=-1 && dgvTemShow.Columns[e.ColumnIndex].Name == "FontColor")
            {
                e.Value = PublicClass.ColorToText(dgvTemShow.Rows[e.RowIndex].Cells["FontColor"].Value.ToString());//颜色转换为汉语
            }
            else if (dgvTemShow.Columns[e.ColumnIndex].Name == "ShowStyle")
            {
                e.Value =PublicClass.AplayToText(Convert.ToInt32(dgvTemShow.Rows[e.RowIndex].Cells["ShowStyle"].Value));//播放方式转换汉语
            }
            else if (dgvTemShow.Columns[e.ColumnIndex].Name == "Tag")
            {
                if (Convert.ToInt32(dgvTemShow.Rows[e.RowIndex].Cells["Tag"].Value) == 0)
                {
                    e.Value = "等待显示";
                }
                if (Convert.ToInt32(dgvTemShow.Rows[e.RowIndex].Cells["Tag"].Value) == 1)
                {
                    e.Value = "等待显示";
                }
                if (Convert.ToInt32(dgvTemShow.Rows[e.RowIndex].Cells["Tag"].Value) == 2)
                {
                    e.Value = "正显示";
                }
            }
        }
    }
}

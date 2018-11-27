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
        }
        private void DgvColumns()
        {
            dgvTemShow.Columns.AddRange(
            new DataGridViewTextBoxColumn { Name = @"ID", HeaderText = @"序号", DataPropertyName = @"ID", Width = 60 },
            new DataGridViewTextBoxColumn { Name = @"ScreenId", DataPropertyName = @"ScreenId", HeaderText = @"屏幕编号",  Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"AddressNum", DataPropertyName = @"AddressNum", HeaderText = @"控制卡地址码", Width = 140 },
            new DataGridViewTextBoxColumn { Name = @"BeginTime", DataPropertyName = @"BeginTime", HeaderText = @"开始时间", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"EndTime", DataPropertyName = @"EndTime", HeaderText = @"结束时间", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"FontName", DataPropertyName = @"FontName", HeaderText = @"字体名称", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"FontSize", DataPropertyName = @"FontSize", HeaderText = @"字体大小", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"FontColor", DataPropertyName = @"FontColor", HeaderText = @"字体颜色", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"ShowStyle", DataPropertyName = @"ShowStyle", HeaderText = @"播放方式", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"Content", DataPropertyName = @"Content", HeaderText = @"显示内容", Width = 500 }
             );
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sKey = string.Empty;
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                sKey = $@"  and  ShowContent like '%{txtKey.Text}%'";
            }
            DataTable dtShow = bllLedShowInfo.GetLEDShowInfos(sKey);
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
                string values = dgvTemShow.Rows[e.RowIndex].Cells["FontColor"].Value.ToString();
                if (values == "Red")
                {
                    e.Value = "红色";
                }
            }
            else if (dgvTemShow.Columns[e.ColumnIndex].Name == "ShowStyle")
            {
                string values = dgvTemShow.Rows[e.RowIndex].Cells["ShowStyle"].Value.ToString();
                if (values == "0")
                {
                    e.Value = "随机显示";
                }
                if (values == "1")
                {
                    e.Value = "立即显示";
                }
                if (values == "2")
                {
                    e.Value = "左移";
                }
                if (values == "3")
                {
                    e.Value = "连续左移";
                }
                if (values == "5")
                {
                    e.Value = "上移";
                }
                if (values == "6")
                {
                    e.Value = "连续上移";
                }
                if (values == "7")
                {
                    e.Value = "下移";
                }
            }
        }
    }
}

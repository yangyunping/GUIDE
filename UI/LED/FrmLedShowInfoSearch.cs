using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI.LED
{
    public partial class FrmLedShowInfoSearch : UserControl
    {
        BllLedShowInfo bllLedShowInfo = new BllLedShowInfo();
        public FrmLedShowInfoSearch()
        {
            InitializeComponent();
            DgvColumns();
        }
        private void DgvColumns()
        {
            dgvTemShow.Columns.AddRange(
            new DataGridViewTextBoxColumn { Name = @"ID", HeaderText = @"序号", DataPropertyName = @"ID", Width = 60 },
            new DataGridViewTextBoxColumn { Name = @"ScreenId", DataPropertyName = @"ScreenId", HeaderText = @"字体名称",  Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"AddressNum", DataPropertyName = @"AddressNum", HeaderText = @"地址码", Width = 120 },
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
    }
}

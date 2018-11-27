using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI.LED
{
    public partial class FrmScreenSettingSearch : UserControl
    {
        BllScreeenSetting screeenSetting = new BllScreeenSetting();
        public FrmScreenSettingSearch()
        {
            InitializeComponent();
            DgvColumns();
            bntDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.LED参数删除);
        }
        private void DgvColumns()
        {
            dgvScreenSetting.Columns.AddRange(
            new DataGridViewTextBoxColumn { Name = @"ID", HeaderText = @"序号", DataPropertyName = @"ID", Width = 60 },
            new DataGridViewTextBoxColumn { Name = @"ScreenId", DataPropertyName = @"ScreenId", HeaderText = @"屏幕编号", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"AddressNum", DataPropertyName = @"AddressNum", HeaderText = @"控制卡地址码", Width = 140 },
            new DataGridViewTextBoxColumn { Name = @"CarName", DataPropertyName = @"CarName", HeaderText = @"控制卡名称", Width = 120 },
            new DataGridViewTextBoxColumn { Name = @"ScreenWidth", DataPropertyName = @"ScreenWidth", HeaderText = @"屏宽", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"ScreenHeight", DataPropertyName = @"ScreenHeight", HeaderText = @"屏高", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"IpAddress", DataPropertyName = @"IpAddress", HeaderText = @"IP地址", Width = 150 },
            new DataGridViewTextBoxColumn { Name = @"ColorStyle", DataPropertyName = @"ColorStyle", HeaderText = @"屏幕颜色", Width = 120 }
             );
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sKey = string.Empty;
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                sKey = $@"  and  ShowContent like '%{txtKey.Text}%'";
            }
            DataTable dtShow = screeenSetting.GetScreenSetting(sKey);
            dgvScreenSetting.AutoGenerateColumns = false;
            dgvScreenSetting.DataSource = dtShow;
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (dgvScreenSetting.CurrentRow != null)
            {
                if (screeenSetting.DeleteScreenSetting(Convert.ToInt32(dgvScreenSetting.CurrentRow.Cells["ID"].Value)))
                {
                    MessageBox.Show("删除成功！");
                    dgvScreenSetting.Rows.Remove(dgvScreenSetting.CurrentRow);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }
    }
}

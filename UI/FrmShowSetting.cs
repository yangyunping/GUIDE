using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmShowSetting : Form
    {
        BllShowInfo bllShowInfo = new BllShowInfo();
        BllAreaInfo bllAreaInfo = new BllAreaInfo();
        private string showId = string.Empty;
        public FrmShowSetting(Configuration configInfo)
        {
            InitializeComponent();

            DataTable dtInfo = bllAreaInfo.GetAreaInfo(string.Empty);
            cmbAreaId.ValueMember = "RowNum";
            cmbAreaId.DisplayMember = "AreaName";
            cmbAreaId.DataSource = dtInfo;
            cmbAreaId.SelectedIndex = -1;

            txtConfigName.Text = configInfo.ConfigName;
            GroupNum.Value = configInfo.ConfigNum;
        }
        public FrmShowSetting(ShowInfo showInfo, Configuration configInfo)
        {
            InitializeComponent();
            DataTable dtInfo = bllAreaInfo.GetAreaInfo(string.Empty);
            cmbAreaId.ValueMember = "RowNum";
            cmbAreaId.DisplayMember = "AreaName";
            cmbAreaId.DataSource = dtInfo;
            cmbAreaId.SelectedIndex = -1;

            showId = showInfo.ID;
            txtConfigName.Text = showInfo.ConfigName;
            cmbAreaId.Text = showInfo.AreaName;
            GroupNum.Value = configInfo.ConfigNum;
            dtpBegin.Value = showInfo.BeginTime;
            dtpEnd.Value = showInfo.EndTime;
            cmbOrder.SelectedIndex = showInfo.ByOrder ? 1 : 0 ;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            cmbAreaId.SelectedIndex = cmbOrder.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbAreaId.Text) && GroupNum.Value > 0 && !string.IsNullOrEmpty(cmbOrder.Text))
                {
                    ShowInfo showInfo = new ShowInfo();
                    showInfo.ID = showId;
                    showInfo.AreaName = cmbAreaId.Text;
                    showInfo.ConfigName = txtConfigName.Text;
                    showInfo.ByOrder = cmbOrder.Text.Equals("正序") ? false : true;
                    showInfo.BeginTime = dtpBegin.Value;
                    showInfo.EndTime = dtpEnd.Value;
                    if (bllShowInfo.InsertOrModifyShow(showInfo))
                    {
                        MessageBox.Show("添加修改成功！");
                        btnReturn_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("添加修改失败！");
                    }
                }
                else
                {
                    MessageBox.Show("信息填写完整！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

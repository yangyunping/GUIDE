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
        BllScreen bllScreen = new BllScreen();
        private int showId = -1;
        /// <summary>
        /// 编号配置
        /// </summary>
        /// <param name="configInfo"></param>
        public FrmShowSetting(Configuration configInfo)
        {
            InitializeComponent();

            DataTable dtInfo = bllAreaInfo.GetAreaInfo(string.Empty);
            cmbAreaId.ValueMember = "AreaId";
            cmbAreaId.DisplayMember = "AreaName";
            cmbAreaId.DataSource = dtInfo;
            cmbAreaId.SelectedIndex = -1;

            txtConfigName.Text = configInfo.ConfigName;
            GroupNum.Value = configInfo.ConfigNum;
        }
        /// <summary>
        /// 显示设置，编号配置
        /// </summary>
        /// <param name="showInfo"></param>
        /// <param name="configInfo"></param>
        public FrmShowSetting(ShowInfo showInfo, Configuration configInfo)
        {
            InitializeComponent();
            DataTable dtInfo = bllAreaInfo.GetAreaInfo(string.Empty);
            cmbAreaId.SelectedIndex = -1;
            cmbAreaId.ValueMember = "AreaId";
            cmbAreaId.DisplayMember = "AreaName";
            cmbAreaId.DataSource = dtInfo;
         
            showId = showInfo.ID;
            txtConfigName.Text = showInfo.ConfigName;
            cmbAreaId.Text = showInfo.AreaName;
            GroupNum.Value = configInfo.ConfigNum;
            dtpBegin.Value = showInfo.BeginTime;
            dtpEnd.Value = showInfo.EndTime;
            cmbOrder.SelectedIndex = showInfo.ByOrder ? 1 : 0 ;
            cmbScreens.Text = showInfo.ScreenId.ToString();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            cmbAreaId.SelectedIndex = cmbOrder.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbAreaId.Text) && GroupNum.Value > 0 && !string.IsNullOrEmpty(cmbOrder.Text) &&  !string.IsNullOrEmpty(cmbScreens.Text))
                {
                    if (cmbOrder.Text.Equals("正序"))
                    {
                        if (cmbScreens.Items.Count - Convert.ToInt32(cmbScreens.Text) < Convert.ToInt32(cmbScreens.Text) + GroupNum.Value)//正序判断是否屏幕范围内
                        {
                            MessageBox.Show("超出屏幕范围，请重新选择！");
                            return;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(cmbScreens.Text) < GroupNum.Value)//倒序判断是否屏幕范围内
                        {
                            MessageBox.Show("超出屏幕范围，请重新选择！");
                            return;
                        }
                    }
                    ShowInfo showInfo = new ShowInfo();
                    showInfo.ID = showId;
                    showInfo.AreaName = cmbAreaId.Text;
                    showInfo.ConfigName = txtConfigName.Text;
                    showInfo.ByOrder = cmbOrder.Text.Equals("正序") ? false : true;
                    showInfo.BeginTime = dtpBegin.Value;
                    showInfo.EndTime = dtpEnd.Value;
                    showInfo.ScreenId =Convert.ToInt32(cmbScreens.Text);
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

        private void cmbAreaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAreaId.SelectedValue != null && !string.IsNullOrEmpty(cmbAreaId.Text) && cmbAreaId.SelectedIndex !=-1)
            {
                cmbScreens.DisplayMember = "ScreenID"; 
                cmbScreens.ValueMember = "AddressNum";
                cmbScreens.DataSource = bllScreen.GetScreenInfo(cmbAreaId.Text);
                cmbScreens.SelectedIndex = -1;
            }
        }

        private void cmbScreens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbScreens.SelectedValue!= null && cmbScreens.SelectedIndex != -1)
            {
                numAddress.Text = cmbScreens.SelectedValue.ToString();
            }
            else
            {
                numAddress.Text = string.Empty;
            }
        }
    }
}

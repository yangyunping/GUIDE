using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmSreenToArea : UserControl
    {
        BllAreaInfo bllAreaInfo = new BllAreaInfo();
        BllScreen bllScreen = new BllScreen();
        BllScreeenSetting bllScreeenSetting = new BllScreeenSetting();
        private int Id = -1;
        public FrmSreenToArea(ScreensToArea screens)
        {
            InitializeComponent();
            DataTable dtInfo = bllAreaInfo.GetAreaInfo(string.Empty);
            cmbArea.ValueMember = "AreaId";
            cmbArea.DisplayMember = "AreaName";
            cmbArea.DataSource = dtInfo;
            cmbArea.SelectedIndex = -1;

            //屏幕信息
            DataTable dtScreen = bllScreeenSetting.GetScreenSetting(string.Empty);
            cmbLEDId.ValueMember = "AddressNum";
            cmbLEDId.DisplayMember = "ScreenID";
            cmbLEDId.DataSource = dtScreen;
            if (screens != null)
            {
                Id = screens.ID;
                cmbArea.SelectedValue = screens.AreaID;
                cmbLEDId.Text = screens.ScreenID.ToString();
                cmbArea.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = bllScreen.GetScreenInfo($" and ScreenID = '{cmbLEDId.Text}'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("该屏幕已匹配区域!");
                return;
            }
            if (!string.IsNullOrEmpty(cmbArea.Text) && !string.IsNullOrEmpty(cmbLEDId.Text))
            {
                try
                {
                    ScreensToArea screens = new ScreensToArea();
                    screens.ID = Id;
                    screens.ScreenID = cmbLEDId.Text;
                    screens.AreaID =Convert.ToInt32(cmbArea.SelectedValue);
                    if (bllScreen.InsertOrModifyScreen(screens))
                    {
                        MessageBox.Show("保存成功!");
                        cmbArea.SelectedIndex = -1;
                        cmbLEDId.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("保存失败，重试!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                ((Form)this.Parent).Close();
            }
        }
    }
}

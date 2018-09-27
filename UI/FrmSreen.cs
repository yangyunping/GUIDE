using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmSreen : UserControl
    {
        BllAreaInfo bllAreaInfo = new BllAreaInfo();
        BllScreen bllScreen = new BllScreen();
        private int screenId = -1;
        public FrmSreen(Screens screens)
        {
            InitializeComponent();

            DataTable dtInfo = bllAreaInfo.GetAreaInfo(string.Empty);
            cmbArea.ValueMember = "AreaId";
            cmbArea.DisplayMember = "AreaName";
            cmbArea.DataSource = dtInfo;
            cmbArea.SelectedIndex = -1;
            if (screens != null)
            {
                screenId = screens.ScreenID;
                cmbArea.Text = screens.AreaName;
                txtAddressNum.Text = screens.AddressNum.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbArea.Text) && !string.IsNullOrEmpty(txtAddressNum.Text))
            {
                try
                {
                    Screens screens = new Screens();
                    screens.ScreenID = screenId;
                    screens.AreaName = cmbArea.Text;
                    screens.AddressNum = Convert.ToInt32(txtAddressNum.Text);
                    if (bllScreen.InsertOrModifyScreen(screens))
                    {
                        MessageBox.Show("保存成功!");
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

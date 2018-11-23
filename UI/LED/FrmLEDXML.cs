using MODEL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmLEDXML : Form
    {
        public FrmLEDXML()
        {
            InitializeComponent();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (PublicClass.CreateXmlInfo(Application.StartupPath + @"\\" + @"ActionShow.txt", "ActionType", "AcitonId", "ActionName", txtTypeId.Text, txtTypeName.Text))
            {
                MessageBox.Show("添加成功！");
                txtTypeId.Clear();
                txtTypeName.Clear();
                txtTypeId.Focus();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
          
        }

        private void btnAddLED_Click(object sender, EventArgs e)
        {
            if (PublicClass.CreateXmlInfo(Application.StartupPath + @"\\" + @"LEDSetting.txt", "LEDNum", "LEDid", "LEDAddress", txtLEDid.Text, txtAdress.Text))
            {
                MessageBox.Show("添加成功！");
                txtLEDid.Clear();
                txtAdress.Clear();
                txtLEDid.Focus();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void txtTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddType_Click(null,null);
            }
        }

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddLED_Click(null, null);
            }
        }
    }
}

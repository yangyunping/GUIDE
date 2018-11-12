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
    public partial class FrmSendLEDShow : Form
    {
        private int dexProgram = 0;
        public FrmSendLEDShow()
        {
            InitializeComponent();
            cmbAddress.SelectedIndex = 0;
        }

        private void btnAddTxt_Click(object sender, EventArgs e)
        {
            LEDShow.AddText( Convert.ToInt32(cmbAddress.Text),txtContent.Text, dexProgram);
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            dexProgram = LEDShow.AddProgram( Convert.ToInt32(cmbAddress.Text),10);
            MessageBox.Show("添加成功！");
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            LEDShow.AddDateTime( Convert.ToInt32(cmbAddress.Text),dexProgram, chkDate.Checked, chkWeek.Checked, chkTime.Checked);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (LEDShow.User_DelAllProgram( Convert.ToInt32(cmbAddress.Text)))
                {
                    MessageBox.Show("删除节目成功！");
                }
                else
                {
                    MessageBox.Show("删除节目失败！");
                }
            }
            catch (Exception ex) { }     
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (LEDShow.SendData( Convert.ToInt32(cmbAddress.Text)))
            {
                MessageBox.Show("发送成功！");
            }
        }
    }
}

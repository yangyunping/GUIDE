using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;

namespace UI
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOriginal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtOriginal.Text.Equals(CurrentInfo.currentEmp.PassWord))
                {
                    MessageBox.Show("密码验证失败!");
                    return;
                }
                else
                {
                    txtNewPwd.Enabled = txtReEnter.Enabled =btnSave.Enabled = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text.Equals(txtReEnter.Text))
            {
                BllEmployee bllEmployee = new BllEmployee();
                if (bllEmployee.UpdatePwd(CurrentInfo.currentEmp.EmployeeNo,txtReEnter.Text.Trim()))
                {
                    MessageBox.Show("修改成功!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("修改失败，检查后重试!");
                }
            }
            else
            {
                MessageBox.Show("两次密码输入不一致!");
            }
        }

        private void txtReEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null,null);
            }
        }
    }
}

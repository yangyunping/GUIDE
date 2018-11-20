using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;

namespace UI
{
    public partial class FrmSelectShow : Form
    {
        public readonly string _configPath = Application.StartupPath + @"\\" + @"Config.ini";//配置文件存放路径
        public FrmSelectShow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSearchOrder.Text))
            {
                PublicClass.WritePrivateProfileString("SelectOrder", "SelectOrderValue", cmbSearchOrder.Text, _configPath);
                MessageBox.Show("保存成功！");
                cmbSearchOrder.SelectedIndex = -1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

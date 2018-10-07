using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MODEL;

namespace UI
{
    public partial class FrmSkinEngine : UserControl
    {
        public readonly string _configPath = Application.StartupPath + @"\\" + @"Config.ini";//配置文件存放路径
        public FrmSkinEngine()
        {
            InitializeComponent();
            string skinPath = Application.StartupPath + @"\Skins";
            this.listBox1.DataSource = new DirectoryInfo(skinPath).GetFiles();
            this.listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                string skinType = (this.listBox1.SelectedItem as FileInfo).FullName;
                skinEngine.SkinFile = skinType;
                skinEngine.SkinAllForm = true;
                skinEngine.DisableTag = 9999;

                if (!string.IsNullOrEmpty(skinType))
                {
                    GetOrSetConfig.WritePrivateProfileString("SkinPath", "SkinPathValue", skinType, _configPath);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

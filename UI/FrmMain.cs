using BLL;
using MODEL;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmMain : Form
    {
        BllAreaInfo BllAreaInfo = new BllAreaInfo();
        public readonly string _configPath = Application.StartupPath + @"\\" + @"Config.ini";//配置文件存放路径
        private string skinType = string.Empty;
        public FrmMain()
        {
            InitializeComponent();
            PowersInite();

            string skinPath = Application.StartupPath + @"\Skins";
            this.listBox1.DataSource = new DirectoryInfo(skinPath).GetFiles();
            this.listBox1.DisplayMember = "Name";
        }

        private void FrmMain_FormClosing1(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PowersInite()
        {
            //tdbShow.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示管理);
            AreaShowSearch.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域设置);
            tsmConfigNum.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.编号设置);
            ShowSetting.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示设置);
            tsmSetting.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.列表顺序设置);
           // tsbBegin.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.启动);
           // tsbEmployee.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.人员管理);
           // tsbConfig.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.配置管理);
            tsmSreen.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示器设置);
        }
        private void AreaShowSearch_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmAreaSearch = new FrmSearchTemplet("区域") { Dock = DockStyle.Fill};
            pnlShow.Controls.Add(frmAreaSearch);
        }

        private void ConfigInfoISearch_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet  frmShowSearch = new FrmSearchTemplet("显示") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmShowSearch);
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
        }

        private void 配置查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmShowSearch = new FrmSearchTemplet("配置") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmShowSearch);

        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSelectShow frmSelectShow = new FrmSelectShow() { Dock = DockStyle.Top};
            pnlShow.Controls.Add(frmSelectShow);
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.ShowDialog();
        }

        private void tsbBegin_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }

        private void tsbEmployee_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmEmpSearch frmEmpSearch = new FrmEmpSearch() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmEmpSearch);
        }

        private void tsbConfig_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmConfig frmConfig = new FrmConfig() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmConfig);
        }

        private void tsbPwd_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmPassword frmPassword = new FrmPassword() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmPassword);
        }

        private void tsmSreen_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmShowSearch = new FrmSearchTemplet("屏幕") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmShowSearch);
        }

        private void 皮肤更换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlThemes.Visible = true;
            //pnlShow.Controls.Clear();
            //FrmSkinEngine frmSkinEngine = new FrmSkinEngine() { Dock = DockStyle.Left };
            //pnlShow.Controls.Add(frmSkinEngine);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.FormClosing += (senders, ex) => {
                GC.Collect();
                Application.Exit();
            };
           StringBuilder selectOrder = new StringBuilder(255);
            GetOrSetConfig.GetPrivateProfileString("SkinPath", "SkinPathValue", " ", selectOrder, 255,
                _configPath);
            if (string.IsNullOrEmpty(selectOrder.ToString()))
            {
                skinEngine1.Active = false;
                return;
            }
            skinEngine1.SkinFile = selectOrder.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                skinType = (this.listBox1.SelectedItem as FileInfo).FullName;
                skinEngine1.SkinFile = skinType;
                skinEngine1.SkinAllForm = true;
                skinEngine1.DisableTag = 9999;
                skinEngine1.Active = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skinType))
            {
                GetOrSetConfig.WritePrivateProfileString("SkinPath", "SkinPathValue", skinType, _configPath);
            }
            pnlThemes.Visible = false;
        }

        private void btnOrigal_Click(object sender, EventArgs e)
        {
            GetOrSetConfig.WritePrivateProfileString("SkinPath", "SkinPathValue", "", _configPath);
            skinEngine1.Active = false;
            pnlThemes.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlThemes.Visible = false;
        }
    }
}

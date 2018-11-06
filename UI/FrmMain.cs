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
            this.lstContent.DataSource = new DirectoryInfo(skinPath).GetFiles();
            this.lstContent.DisplayMember = "Name";
        }

        private void FrmMain_FormClosing1(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 权限控制
        /// </summary>
        private void PowersInite()
        {
            //tdbShow.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示管理);
            AreaShowSearch.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域设置);
            tsmConfigNum.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.编号设置);
            tsmSearchManage.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示设置);
            tsmSetting.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.列表顺序设置);
           // tsbBegin.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.启动);
           // tsbEmployee.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.人员管理);
           // tsbConfig.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.配置管理);
            tsmSreen.Visible = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示器设置);
        }
        /// <summary>
        /// 区域设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaShowSearch_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmAreaSearch = new FrmSearchTemplet("区域") { Dock = DockStyle.Fill};
            pnlShow.Controls.Add(frmAreaSearch);
        }
        /// <summary>
        /// 清空主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbClear_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
        }
        /// <summary>
        /// 编组设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 配置查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmShowSearch = new FrmSearchTemplet("配置") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmShowSearch);

        }
        /// <summary>
        /// 显示按指定条件顺序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelectShow frmSelectShow = new FrmSelectShow();
            frmSelectShow.ShowDialog();
        }
        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbBegin_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.ShowDialog();
        }
        /// <summary>
        /// 关闭界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 配置信息（权限等）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbConfig_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmConfig frmConfig = new FrmConfig() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmConfig);
        }
        /// <summary>
        /// 显示器设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSreen_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmShowSearch = new FrmSearchTemplet("屏幕") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmShowSearch);
        }
        /// <summary>
        /// 皮肤更换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 皮肤更换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstContent.Enabled = true;
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
        /// <summary>
        /// 皮肤应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.lstContent.SelectedItem != null)
                {
                    skinType = (this.lstContent.SelectedItem as FileInfo).FullName;
                    skinEngine1.SkinFile = skinType;
                    skinEngine1.SkinAllForm = true;
                    skinEngine1.DisableTag = 9999;
                }
            }
            catch (Exception ex) { }
           
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
            lstContent.Enabled = false;
            pnlThemes.Visible = false;
        }
        /// <summary>
        /// 显示查询管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSearchManage_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmAreaSearch = new FrmSearchTemplet("显示") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmAreaSearch);
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPassword frmPassword = new FrmPassword();
            frmPassword.ShowDialog();
        }
    }
}

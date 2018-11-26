using BLL;
using MODEL;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using UI.LED;

namespace UI
{
    public partial class FrmMain : Form
    {
        BllAreaInfo BllAreaInfo = new BllAreaInfo();
        BllLedShowInfo ledShowInfo = new BllLedShowInfo();
        public readonly string _configPath = Application.StartupPath + @"\\" + @"Config.ini";//配置文件存放路径
        private string skinType = string.Empty;
        public FrmMain()
        {
            InitializeComponent();
            PowersInite();
            timer1.Start();//开始预设显示
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
            AreaShowSearch.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域设置);
            tsmConfigNum.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.编号设置);
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
            PublicClass.GetPrivateProfileString("SkinPath", "SkinPathValue", " ", selectOrder, 255,
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
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skinType))
            {
                PublicClass.WritePrivateProfileString("SkinPath", "SkinPathValue", skinType, _configPath);
            }
            pnlThemes.Visible = false;
        }

        private void btnOrigal_Click(object sender, EventArgs e)
        {
            PublicClass.WritePrivateProfileString("SkinPath", "SkinPathValue", "", _configPath);
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
            FrmLedShowInfoSearch frmAreaSearch = new FrmLedShowInfoSearch() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmAreaSearch);
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPassword frmPassword = new FrmPassword();
            frmPassword.ShowDialog();
        }

        private void tsmDefinedShow_Click(object sender, EventArgs e)
        {
            FrmDefinedShow frmDefinedShow = new FrmDefinedShow();
            frmDefinedShow.ShowDialog();
        }

        private void 模板查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmTempletSearch frmTempletSearch = new FrmTempletSearch() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmTempletSearch);
        }

        private void 排序查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmAreaSearch = new FrmSearchTemplet("显示") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmAreaSearch);
        }

        private void 模板设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempletLED frmTempletLED = new FrmTempletLED();
            frmTempletLED.ShowDialog();
        }

        private void lED显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dtShow = ledShowInfo.GetLEDShowInfos($@" and BeginTime <= CONVERT (CHAR(10), GETDATE(), 108) and EndTime >= CONVERT (CHAR(10), GETDATE(), 108)");
            
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                int addressNum = Convert.ToInt32(dtShow.Rows[i]["AddressNum"]);
                LEDShow.DeleteProgram(addressNum);//删除现有显示
                int programInx = LEDShow.AddProgram(addressNum, 10);
                if (LEDShow.LedOpen(Convert.ToInt32(addressNum)))
                {
                    LEDShow.AddText(addressNum, dtShow.Rows[i]["Content"].ToString(), programInx, Convert.ToInt32(dtShow.Rows[i]["ShowStyle"]), dtShow.Rows[i]["FontName"].ToString(), Convert.ToInt32(dtShow.Rows[i]["FontSize"]), 0x00FF);
                }
                else
                {
                    continue;
                }
                if (!LEDShow.SendData(addressNum))
                {
                    MessageBox.Show(dtShow.Rows[i]["ScreenId"].ToString() + "发送失败！");
                }
            }
        }

        private void 模板显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempletSendLED frmTempletSendLED = new FrmTempletSendLED();
            frmTempletSendLED.ShowDialog();
        }

        private void tsmReadyShow_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmLedShowInfoSearch frmAreaSearch = new FrmLedShowInfoSearch() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmAreaSearch);
        }

        private void lED参数配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLEDSetting frmLEDSetting = new FrmLEDSetting();
            frmLEDSetting.ShowDialog();
        }

        private void 排序设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmByOrderShow frmByOrderShow = new FrmByOrderShow();
            frmByOrderShow.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //预设显示
                DataTable dtShow = ledShowInfo.GetLEDShowInfos($@" and  Tag != 2  and  BeginTime <= CONVERT (CHAR(10), GETDATE(), 108) and EndTime >= CONVERT (CHAR(10), GETDATE(), 108)");
                for (int i = 0; i < dtShow.Rows.Count; i++)
                {
                    int addressNum = Convert.ToInt32(dtShow.Rows[i]["AddressNum"]);
                    LEDShow.DeleteProgram(addressNum);//删除现有显示
                    int programInx = LEDShow.AddProgram(addressNum, 10);
                    if (LEDShow.LedOpen(Convert.ToInt32(addressNum)))
                    {
                        LEDShow.AddText(addressNum, dtShow.Rows[i]["Content"].ToString(), programInx, Convert.ToInt32(dtShow.Rows[i]["ShowStyle"]), dtShow.Rows[i]["FontName"].ToString(), Convert.ToInt32(dtShow.Rows[i]["FontSize"]), 0x00FF);
                    }
                    else
                    {
                        continue;
                    }
                    if (LEDShow.SendData(addressNum))
                    {
                        ledShowInfo.UpdateLEDShowInfo(Convert.ToInt32(dtShow.Rows[i]["ID"]),2);
                    }
                    else
                    {
                        MessageBox.Show(dtShow.Rows[i]["ScreenId"].ToString() + "发送失败！");
                    }
                }
                //到结束时间，停止显示
                DataTable dtOutShow = ledShowInfo.GetLEDShowInfos($@" and  Tag = 2 and  EndTime < CONVERT (CHAR(10), GETDATE(), 108)");
                for (int i = 0; i < dtOutShow.Rows.Count; i++)
                {
                    int addressNum = Convert.ToInt32(dtShow.Rows[i]["AddressNum"]);
                    LEDShow.DeleteProgram(addressNum);//删除现有显示
                    LEDShow.User_CloseScreen(addressNum);//关屏
                    ledShowInfo.UpdateLEDShowInfo(Convert.ToInt32(dtShow.Rows[i]["ID"]), 0);
                }
            }
            catch (Exception) { }
        }
    }
}

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
            ShowTimer.Start();//开始预设显示
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
            tsmSreenToArea.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域LED匹配);
            tsmScreenSetting.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.LED参数配置);
            tsmByOrderSet.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.排序设置);
            tsmResetOrderShow.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.重置预显示);
            tsmTempletShow.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.模板LED显示);
            tsmTepletSet.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.模板设置);
            tsmDefinedShow.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.自定义LED显示);
            tsbConfig.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.配置信息);
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
            FrmiAplay FrmiAplay = new FrmiAplay();
            FrmiAplay.ShowDialog();
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
        /// <summary>
        /// 保存皮肤到本地文件缓存中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skinType))
            {
                PublicClass.WritePrivateProfileString("SkinPath", "SkinPathValue", skinType, _configPath);
            }
            pnlThemes.Visible = false;
        }
        /// <summary>
        /// 加载本地的所有皮肤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrigal_Click(object sender, EventArgs e)
        {
            PublicClass.WritePrivateProfileString("SkinPath", "SkinPathValue", "", _configPath);
            skinEngine1.Active = false;
            pnlThemes.Visible = false;
        }
        /// <summary>
        /// 关闭皮肤操作框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        ///密码修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPassword frmPassword = new FrmPassword();
            frmPassword.ShowDialog();
        }
        /// <summary>
        /// 自定义显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmDefinedShow_Click(object sender, EventArgs e)
        {
            FrmDefinedShow frmDefinedShow = new FrmDefinedShow();
            frmDefinedShow.ShowDialog();
        }
        /// <summary>
        /// 模板查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 模板查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmTempletSearch frmTempletSearch = new FrmTempletSearch() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmTempletSearch);
        }
        /// <summary>
        /// 模板设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 模板设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempletLED frmTempletLED = new FrmTempletLED();
            frmTempletLED.ShowDialog();
        }
        /// <summary>
        ///LED预显示重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmResetOrderShow_Click(object sender, EventArgs e)
        {
            DataTable dtALLShow = ledShowInfo.GetLEDShowInfos($@" and  Tag = 2 ");
            for (int i = 0; i < dtALLShow.Rows.Count; i++)
            {
                ledShowInfo.UpdateLEDShowInfo(Convert.ToInt32(dtALLShow.Rows[i]["ID"]), 0);
            }
        }
        /// <summary>
        /// 模板显示操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 模板显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTempletSendLED frmTempletSendLED = new FrmTempletSendLED();
            frmTempletSendLED.ShowDialog();
        }
        /// <summary>
        /// 预显示查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmReadyShow_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmLedShowInfoSearch frmAreaSearch = new FrmLedShowInfoSearch() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmAreaSearch);
        }
        /// <summary>
        /// 参数配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lED参数配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLEDSetting frmLEDSetting = new FrmLEDSetting();
            frmLEDSetting.ShowDialog();
        }
        /// <summary>
        /// 排序设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 排序设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmByOrderShow frmByOrderShow = new FrmByOrderShow();
            frmByOrderShow.ShowDialog();
        }
        /// <summary>
        /// timer 实时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    int programInx = LEDShow.AddProgram(addressNum, 10);//添加节目
                    if (LEDShow.LedOpen(Convert.ToInt32(addressNum)))
                    {
                        //添加显示内容
                        LEDShow.AddText(addressNum, Convert.ToInt32(dtShow.Rows[i]["ScreenWidth"]), Convert.ToInt32(dtShow.Rows[i]["ScreenHeight"]),dtShow.Rows[i]["Content"].ToString(), programInx, Convert.ToInt32(dtShow.Rows[i]["ShowStyle"]), dtShow.Rows[i]["FontName"].ToString(), Convert.ToInt32(dtShow.Rows[i]["FontSize"]), 0x00FF,Convert.ToBoolean(dtShow.Rows[i]["FontBold"]), Convert.ToInt32(dtShow.Rows[i]["Position"]));//最后0  左对齐 1居中 2右对齐
                    }
                    else
                    {
                        continue;
                    }
                    if (LEDShow.SendData(addressNum))//发送数据
                    {
                        ledShowInfo.UpdateLEDShowInfo(Convert.ToInt32(dtShow.Rows[i]["ID"]),2);//更新状态
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
                    ledShowInfo.UpdateLEDShowInfo(Convert.ToInt32(dtShow.Rows[i]["ID"]), 0);//更新状态
                }
            }
            catch (Exception) { }
        }
        /// <summary>
        /// LED参数查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lED参数查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmScreenSettingSearch frmScreenSettingSearch = new FrmScreenSettingSearch() { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmScreenSettingSearch);
        }
    }
}

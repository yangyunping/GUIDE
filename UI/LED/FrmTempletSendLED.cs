using MODEL;
using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using System.Configuration;
using System.Collections.Generic;

namespace UI.LED
{
    public partial class FrmTempletSendLED : Form
    {
        BllTempletShow templetShow = new BllTempletShow();
        BllLedShowInfo bllLedShowInfo = new BllLedShowInfo();
        private TempletShow tempInfo = new TempletShow();
        private DataTable dtContent; //显示内容
        BllScreeenSetting bllScreeenSetting = new BllScreeenSetting();
        private DataTable dtScreen = null; //屏幕信息
        private int sWidth = 0;//屏宽
        private int sHeight = 0;//屏高
        private int allFontSize = 0;//字体大小
        private string fontName = "宋体";//字体名称
        private string fontColor = "Red";//字体颜色
        private int showType = 0;//播放方式
        Dictionary<int, string> screenInfo = new Dictionary<int, string>();//勾选的屏幕信息  地址码  屏幕编号
        public FrmTempletSendLED()
        {
            InitializeComponent();
            IniteData();
        }
        public FrmTempletSendLED(string showContent)
        {
            InitializeComponent();
            IniteData();
            cmbContent.Text = showContent;
        }
        /// <summary>
        /// 基础信息加载
        /// </summary>
        private void IniteData()
        {
            //模板内容
            dtContent = templetShow.GetTempletShows(string.Empty);
            cmbContent.ValueMember = "ID";
            cmbContent.DisplayMember = "ShowContent";
            cmbContent.DataSource = dtContent;
            cmbContent.SelectedIndex = 0;

            //播放方式
            string txtPath = Application.StartupPath + @"\\" + @"ActionShow.txt";
            DataTable dt = new DataTable();
            dt.Columns.Add("编号");
            dt.Columns.Add("播放名称");
            DataTable dtAction = PublicClass.GetXMLInfo(txtPath, dt, "ActionType", "AcitonId", "ActionName");
            cmbShowType.DataSource = dtAction;
            cmbShowType.ValueMember = "编号";
            cmbShowType.DisplayMember = "播放名称";

            //LED编号
            //屏幕信息
            dtScreen = bllScreeenSetting.GetScreenSetting(string.Empty);
            lstScreenIds.DataSource = dtScreen;
            lstScreenIds.ValueMember = "AddressNum";
            lstScreenIds.DisplayMember = "ScreenID";

            cmbShowType.SelectedIndex = cmbPosition.SelectedIndex = 0;
        }
        //显示时间
        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpBegin.Enabled = dtpEnd.Enabled = chkDate.Checked;
        }
        /// <summary>
        ///保存到发送记录表中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtScreenId.Text.Trim()))
                {
                    MessageBox.Show("请录入需要显示的屏幕编号!");
                    return;
                }
                if (string.IsNullOrEmpty(txtTIme.Text))
                {
                    MessageBox.Show("请录入显示时长!");
                    return;
                }
                showType = Convert.ToInt32(cmbShowType.SelectedValue);//播放方式
                CurrentInfo.DataSendErro = string.Empty;//主界面错误提示信息
                foreach (var item in screenInfo)
                {
                    int fontSize = 0;//字体大小
                    LEDShowInfo lEDShowInfo = new LEDShowInfo();
                    if (dtScreen.Rows.Count > 0)
                    {
                        DataRow[] screenRow = dtScreen.Select($"AddressNum = {item.Key}");
                        sWidth = Convert.ToInt32(screenRow[0]["ScreenWidth"]);
                        sHeight = Convert.ToInt32(screenRow[0]["ScreenHeight"]);
                        lEDShowInfo.FontSize = allFontSize == 0 ? fontSize = Convert.ToInt32(screenRow[0]["FontSize"]) : fontSize = allFontSize;//字体大小设置了就用设置的，没有设置就用屏幕自带参数
                    }
                    lEDShowInfo.AddressNum = Convert.ToInt32(item.Key);
                    lEDShowInfo.ScreenId = item.Value;
                    lEDShowInfo.ShowStyle = showType;
                    lEDShowInfo.FontName = fontName;
                    lEDShowInfo.FontColor = fontColor;
                    lEDShowInfo.FontSize = fontSize;
                    lEDShowInfo.Content = cmbContent.Text.Trim();
                    lEDShowInfo.Duration = Convert.ToInt32(txtTIme.Text);
                    lEDShowInfo.DeleteUpProgram = chkDelete.Checked;
                    if (chkDate.Checked) //保存发送记录表定时发送
                    {
                        if (dtpEnd.Value.Hour <= dtpBegin.Value.Hour && dtpEnd.Value.Minute - dtpBegin.Value.Minute < 1)//显示时长提示
                        {
                            MessageBox.Show("设置的显示时间少于1分钟,请重新设置！");
                            return;
                        }
                        lEDShowInfo.Tag = 0;
                        lEDShowInfo.BeginTime = dtpBegin.Value.ToShortTimeString();
                        lEDShowInfo.EndTime = dtpEnd.Value.ToShortTimeString();
                        if (!bllLedShowInfo.InsertLedShowInfo(lEDShowInfo))
                        {
                            CurrentInfo.DataSendErro += item.Value + ",  ";
                        }
                    }
                    else //实时发送，不定时
                    {
                        if (chkDelete.Checked)
                        {
                            LEDShow.DeleteProgram(item.Key);//删除指定控制卡所有节目
                        }
                        int programInx = LEDShow.AddProgram(item.Key, Convert.ToInt32(txtTIme.Text));
                        if (LEDShow.LedOpen(item.Key))
                        {
                            int postion = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : 1; //左对齐 1居中 2右对齐
                            if (string.IsNullOrEmpty(cmbPosition.Text))
                            {
                                //单行文本不存在位置显示 
                                LEDShow.AddSingleText(item.Key, sWidth, sHeight, cmbContent.Text, programInx, showType, fontName, fontSize, 0x00FF, chkFoild.Checked, postion);
                            }
                            else
                            {
                                //文本区域显示（左对齐 1居中 2右对齐）
                                LEDShow.AddText(item.Key, sWidth, sHeight, cmbContent.Text, programInx, showType, fontName, fontSize, 0x00FF, chkFoild.Checked, postion);
                            }
                            if (LEDShow.SendData(item.Key))
                            {
                                lEDShowInfo.Tag = 1;
                                bllLedShowInfo.InsertLedShowInfo(lEDShowInfo);
                            }
                            else
                            {
                                CurrentInfo.DataSendErro += item.Value + ", ";
                            }
                        }
                        else
                        {
                            CurrentInfo.DataSendErro += item.Value + ", ";
                            return;
                        }
                    }
                }
                MessageBox.Show("发送成功！");
                if (!string.IsNullOrEmpty(CurrentInfo.DataSendErro))
                {
                    CurrentInfo.DataSendErro += "  发送失败!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFontSetting_Click(object sender, EventArgs e)
        {
            if (fontDialogled.ShowDialog() == DialogResult.OK)
            {
                allFontSize = Convert.ToInt32(fontDialogled.Font.Size);
                fontName = fontDialogled.Font.Name;
            }
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialogLed.ShowDialog() == DialogResult.OK)
            {
                fontColor = colorDialogLed.Color.Name;
            }
        }

        private void fontDialogled_Apply(object sender, EventArgs e)
        {
            if (colorDialogLed.ShowDialog() == DialogResult.OK)
            {
                fontColor = colorDialogLed.Color.Name;
            }
        }

        private void txtScreenId_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlScreenIds.Visible = true;

            for (int i = 0; i < lstScreenIds.Items.Count; i++)
            {
                if (screenInfo.ContainsValue(lstScreenIds.GetItemText(lstScreenIds.Items[i])))
                {
                    lstScreenIds.SetItemChecked(i, true);
                }
            }
            //foreach (CheckBox item in lstScreenIds.Items)
            //{
            //    if (screenInfo.ContainsValue(item.Text))
            //    {
            //        item.SetItemChecked(0, true);
            //    }
            //}
        }

        private void btnlstClose_Click(object sender, EventArgs e)
        {
            txtScreenId.Clear();
            foreach (var item in screenInfo.Values)
            {
                txtScreenId.Text += item + ",";
            }
            pnlScreenIds.Visible = false;
        }

        private void lstScreenIds_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lstScreenIds.GetItemCheckState(e.Index) == CheckState.Checked)
            {
                if (screenInfo.ContainsValue(lstScreenIds.Text))
                {
                    screenInfo.Remove(Convert.ToInt32(lstScreenIds.SelectedValue));
                }
            }
            else
            {
                if (!screenInfo.ContainsValue(lstScreenIds.Text))
                {
                    screenInfo.Add(Convert.ToInt32(lstScreenIds.SelectedValue), lstScreenIds.Text);
                }
            }
        }
    }
}

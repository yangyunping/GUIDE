using MODEL;
using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using System.Configuration;

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
            cmbContent.SelectedIndex = -1;

            //LED编号
            //屏幕信息
            dtScreen = bllScreeenSetting.GetScreenSetting(string.Empty);
            cmbLEDId.ValueMember = "AddressNum";
            cmbLEDId.DisplayMember = "ScreenID";
            cmbLEDId.DataSource = dtScreen;
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
                if (chkDate.Checked) //保存发送记录表定时发送
                {
                    LEDShowInfo lEDShowInfo = new LEDShowInfo();
                    lEDShowInfo.AddressNum = Convert.ToInt32(cmbLEDId.SelectedValue);
                    lEDShowInfo.ScreenId = cmbLEDId.Text;
                    lEDShowInfo.ShowStyle = tempInfo.ShowStyle;
                    lEDShowInfo.BeginTime = DateTime.Now;
                    lEDShowInfo.EndTime = DateTime.Now;
                    lEDShowInfo.FontName = tempInfo.FontName;
                    lEDShowInfo.FontSize = tempInfo.FontSize;
                    lEDShowInfo.FontColor = tempInfo.FontColor;
                    lEDShowInfo.Content = tempInfo.ShowContent;
                    lEDShowInfo.Tag = 1;
                    lEDShowInfo.Duration = Convert.ToInt32(txtTIme.Text);
                    if (bllLedShowInfo.InsertLedShowInfo(lEDShowInfo))
                    {
                        MessageBox.Show("保存成功！");
                    }
                    else
                    {
                        MessageBox.Show("保存失败！");
                    }
                }
                else //实时发送，不定时
                {
                    if (chkDelete.Checked)
                    {
                        LEDShow.DeleteProgram(Convert.ToInt32(cmbLEDId.SelectedValue));//删除指定控制卡所有节目
                    }
                    int programInx = LEDShow.AddProgram(Convert.ToInt32(cmbLEDId.SelectedValue), Convert.ToInt32(txtTIme.Text));
                    if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))
                    {
                        int postion = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : -1; //左对齐 1居中 2右对齐  -1不选
                        if (postion == -1) //单行文本不存在位置显示 （左对齐 1居中 2右对齐）
                        {
                            LEDShow.AddSingleText(Convert.ToInt32(cmbLEDId.SelectedValue), sWidth, sHeight, cmbContent.Text, programInx, tempInfo.ShowStyle, tempInfo.FontName, tempInfo.FontSize, 0x00FF, chkFoild.Checked, postion);
                        }
                        else //区域显示
                        {
                            LEDShow.AddText(Convert.ToInt32(cmbLEDId.SelectedValue), sWidth, sHeight, cmbContent.Text, programInx, tempInfo.ShowStyle, tempInfo.FontName, tempInfo.FontSize, 0x00FF, chkFoild.Checked, postion);
                        }
                        if (LEDShow.SendData(Convert.ToInt32(cmbLEDId.SelectedValue)))
                        {
                            MessageBox.Show("发送成功！");
                        }
                        else
                        {
                            MessageBox.Show("发送失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("屏幕连接失败！");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbContent.Text))
                {
                    DataRow[] row = dtContent.Select($"ID = '{cmbContent.SelectedValue}'");
                    txtFontName.Text = row[0]["FontName"].ToString();
                    txtFontSize.Text = row[0]["FontSize"].ToString();
                    txtiAplay.Text = PublicClass.AplayToText(Convert.ToInt32(row[0]["ShowStyle"]));
                    tempInfo.FontName = row[0]["FontName"].ToString();
                    tempInfo.FontSize = Convert.ToInt32(row[0]["FontSize"]);
                    tempInfo.FontColor = row[0]["FontColor"].ToString();
                    tempInfo.ShowStyle = Convert.ToInt32(row[0]["ShowStyle"]);
                    tempInfo.ShowContent = row[0]["ShowContent"].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// 显示内容切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLEDId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbLEDId.Text))
                {
                    if (dtScreen.Rows.Count > 0)
                    {
                        DataRow[] screenRow = dtScreen.Select($"AddressNum = {cmbLEDId.SelectedValue}");
                        sWidth = Convert.ToInt32(screenRow[0]["ScreenWidth"]);
                        sHeight = Convert.ToInt32(screenRow[0]["ScreenHeight"]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}

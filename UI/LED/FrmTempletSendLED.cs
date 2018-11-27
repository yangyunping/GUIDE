using MODEL;
using System;
using System.Data;
using System.Windows.Forms;
using BLL;

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
            //string txtPath = Application.StartupPath + @"\\" + @"LEDSetting.txt";
            //DataTable dt = new DataTable();
            //dt.Columns.Add("编号");
            //dt.Columns.Add("地址");
            //DataTable dtLED = PublicClass.GetXMLInfo(txtPath, dt, "LEDNum", "LEDid", "LEDAddress");
            //cmbLEDId.ValueMember = "地址";
            //cmbLEDId.DisplayMember = "编号";
            //cmbLEDId.DataSource = dtLED;
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpBegin.Enabled = dtpEnd.Enabled = chkDate.Checked;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkDate.Checked)
                {
                    LEDShowInfo lEDShowInfo = new LEDShowInfo();
                    lEDShowInfo.AddressNum = Convert.ToInt32(cmbLEDId.SelectedValue);
                    lEDShowInfo.ScreenId = cmbLEDId.Text;
                    lEDShowInfo.ShowStyle = tempInfo.ShowStyle;
                    lEDShowInfo.BeginTime = dtpBegin.Value;
                    lEDShowInfo.EndTime = dtpEnd.Value;
                    lEDShowInfo.FontName = tempInfo.FontName;
                    lEDShowInfo.FontSize = tempInfo.FontSize;
                    lEDShowInfo.FontColor = tempInfo.FontColor;
                    lEDShowInfo.Content = tempInfo.ShowContent;
                    lEDShowInfo.Tag =1;
                    if (bllLedShowInfo.InsertLedShowInfo(lEDShowInfo))
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
                    if (chkDelete.Checked)
                    {
                        LEDShow.DeleteProgram(Convert.ToInt32(cmbLEDId.SelectedValue));//删除指定控制卡所有节目
                    }
                    int programInx = LEDShow.AddProgram(Convert.ToInt32(cmbLEDId.SelectedValue), 10);
                    if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))
                    {
                        int postion = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : 0; //左对齐 1居中 2右对齐
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
            }
            catch { }
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
                    tempInfo.FontName = row[0]["FontName"].ToString();
                    tempInfo.FontSize = Convert.ToInt32(row[0]["FontSize"]);
                    tempInfo.FontColor = row[0]["FontColor"].ToString();
                    tempInfo.ShowStyle = Convert.ToInt32(row[0]["ShowStyle"]);
                    tempInfo.ShowContent = row[0]["ShowContent"].ToString();
                }
            }
            catch { }
        }

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
            catch (Exception) { }
        }
    }
}

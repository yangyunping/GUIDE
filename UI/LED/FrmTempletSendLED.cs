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
        private DataTable dtContent;
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
            string txtPath = Application.StartupPath + @"\\" + @"LEDSetting.txt";
            DataTable dt = new DataTable();
            dt.Columns.Add("编号");
            dt.Columns.Add("地址");
            DataTable dtLED = PublicClass.GetXMLInfo(txtPath, dt, "LEDNum", "LEDid", "LEDAddress");
            cmbLEDId.ValueMember = "地址";
            cmbLEDId.DisplayMember = "编号";
            cmbLEDId.DataSource = dtLED;
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
                    int programInx = LEDShow.AddProgram(Convert.ToInt32(cmbLEDId.SelectedValue), 10);
                    if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))
                    {
                        LEDShow.AddText(Convert.ToInt32(cmbLEDId.SelectedValue), cmbContent.Text, programInx, tempInfo.ShowStyle, tempInfo.FontName, tempInfo.FontSize, 0x00FF);
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
    }
}

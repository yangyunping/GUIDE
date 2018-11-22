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
        private TempletShow tempInfo = new TempletShow();
        private DataTable dtContent;
        public FrmTempletSendLED()
        {
            InitializeComponent();

            dtContent = templetShow.GetTempletShows(string.Empty);
            cmbContent.ValueMember = "ID";
            cmbContent.DisplayMember = "ShowContent";
            cmbContent.DataSource = dtContent;
          

            //LED
            string txtPath = Application.StartupPath + @"\\" + @"LEDSetting.txt";
            DataTable dt = new DataTable();
            dt.Columns.Add("编号");
            dt.Columns.Add("地址");
            DataTable dtLED = PublicClass.GetXMLInfo(txtPath, dt, "LEDNum", "LEDid", "LEDAddress");
            cmbLEDId.DataSource = dtLED;
            cmbLEDId.ValueMember = "地址";
            cmbLEDId.DisplayMember = "编号";
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpBegin.Enabled = dtpEnd.Enabled = chkDate.Checked;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (chkDate.Checked)
            {

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
                }
            }
            catch { }
        }
    }
}

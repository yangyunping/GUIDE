using MODEL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using BLL;

namespace UI.LED
{
    public partial class FrmTempletLED : Form
    {
        private int fontSize = 24;//字体大小
        private string fontName = "宋体";//字体名称
        private string fontColor = "";//字体颜色
        BllTempletShow bllTempletShow = new BllTempletShow();
        public FrmTempletLED()
        {
            InitializeComponent();

            string txtPath = Application.StartupPath + @"\\" + @"LEDSetting.txt";
            if (File.Exists(txtPath))
            {
                //播放方式
                DataTable dt = new DataTable();
                dt.Columns.Add("编号");
                dt.Columns.Add("名称");
                DataTable dtAction = PublicClass.GetXMLInfo(txtPath, dt, "ActionType", "AcitonId", "ActionName");
                cmbShowType.DataSource = dtAction;
                cmbShowType.ValueMember = "编号";
                cmbShowType.DisplayMember = "名称";
            }
        }

        private void btnFontSetting_Click(object sender, EventArgs e)
        {
            fontDialogled.ShowDialog();
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            colorDialogLed.ShowDialog();
        }

        private void btnSava_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbShowType.SelectedValue.ToString()) ||string.IsNullOrEmpty(txtContent.Text))
            {
                if (fontDialogled.ShowDialog() == DialogResult.OK)
                {
                    fontSize = Convert.ToInt32(fontDialogled.Font.Size);
                    fontName = fontDialogled.Font.Name;
                }
                if (colorDialogLed.ShowDialog() == DialogResult.OK)
                {
                    fontColor = colorDialogLed.Color.Name;
                }
                TempletShow templetShow = new TempletShow();
                templetShow.FontColor = fontColor;
                templetShow.FontName = fontName;
                templetShow.FontSize = fontSize;
                templetShow.ShowContent = txtContent.Text.Trim();
                templetShow.ShowStyle = Convert.ToInt32(cmbShowType.SelectedValue);
                if (bllTempletShow.InsertTempletShow(templetShow))
                {
                    MessageBox.Show("添加模板成功！");
                    txtContent.Clear();
                }
            }
            else
            {
                MessageBox.Show("请完善信息！");
            }
        }
    }
}

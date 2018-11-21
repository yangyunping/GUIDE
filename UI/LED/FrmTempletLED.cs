using MODEL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class FrmTempletLED : Form
    {
        private int fontSize = 24;//字体大小
        private string fontName = "宋体";//字体名称
        private string fontColor = "Red";//字体颜色
        BllTempletShow bllTempletShow = new BllTempletShow();
        private int templetId = -1;
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
        public FrmTempletLED(TempletShow templetShow)
        {
            InitializeComponent();
            templetId = templetShow.ID;
            cmbShowType.SelectedValue = templetShow.ShowStyle;
            txtContent.Text = templetShow.ShowContent;
            fontName = templetShow.FontName;
            fontSize = templetShow.FontSize;
            fontColor = templetShow.FontColor;
        }

        private void btnFontSetting_Click(object sender, EventArgs e)
        {
            if (fontDialogled.ShowDialog() == DialogResult.OK)
            {
                fontSize = Convert.ToInt32(fontDialogled.Font.Size);
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

        private void btnSava_Click(object sender, EventArgs e)
        {
            TempletShow templetShow = new TempletShow();
            templetShow.FontColor = fontColor;
            templetShow.FontName = fontName;
            templetShow.FontSize = fontSize;
            templetShow.ShowContent = txtContent.Text.Trim();
            templetShow.ShowStyle = Convert.ToInt32(cmbShowType.SelectedValue);
            if (!string.IsNullOrEmpty(cmbShowType.SelectedValue.ToString()) && !string.IsNullOrEmpty(txtContent.Text))
            {
                if (templetId == -1)
                {
                    if (bllTempletShow.InsertTempletShow(templetShow))
                    {
                        MessageBox.Show("添加模板成功！");
                        txtContent.Clear();
                    }
                }
                else
                {
                    templetShow.ID = templetId;
                    if (bllTempletShow.ModifyTempletShow(templetShow))
                    {
                        MessageBox.Show("修改模板成功！");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("请完善信息！");
            }
        }
    }
}

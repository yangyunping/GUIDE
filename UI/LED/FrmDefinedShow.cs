using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class FrmDefinedShow : Form
    {
        private int programInx = 0;//节目数量
        private int fontSize = 24;//字体大小
        private int fontColor = 0x00FF;//字体颜色
        private string fontName = "宋体";//字体名称
        BllScreeenSetting bllScreeenSetting = new BllScreeenSetting();
        private DataTable dtScreen = null;
        private int sWidth = 0;
        private int sHeight = 0;
        public FrmDefinedShow()
        {
            InitializeComponent();
            IniteData();
        }
        /// <summary>
        /// 加载基础信息
        /// </summary>
        private void IniteData()
        {
            //txt文件读取信息
            string actionShowPath = Application.StartupPath + @"\\" + @"ActionShow.txt";//播放方式文件 
            if (File.Exists(actionShowPath))
            {
                //播放方式
                DataTable dt = new DataTable();
                dt.Columns.Add("编号");
                dt.Columns.Add("名称");
                DataTable dtAction = PublicClass.GetXMLInfo(actionShowPath, dt, "ActionType", "AcitonId", "ActionName");
                cmbShowType.DataSource = dtAction;
                cmbShowType.ValueMember = "编号";
                cmbShowType.DisplayMember = "名称";
            }
            //屏幕信息
            dtScreen = bllScreeenSetting.GetScreenSetting(string.Empty);
            cmbLEDId.ValueMember = "AddressNum";
            cmbLEDId.DisplayMember = "ScreenID";
            cmbLEDId.DataSource = dtScreen;
        }
        private void btnFontSetting_Click(object sender, EventArgs e)
        {
            if (fontDialogLed.ShowDialog()== DialogResult.OK)
            {
                //设置字体类型和大小
                fontName = fontDialogLed.Font.Name;
                fontSize = Convert.ToInt32(fontDialogLed.Font.Size);
            }
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            try
            {
                //设置字体颜色
                if (colorDialogLed.ShowDialog() == DialogResult.OK)
                {
                    string name = colorDialogLed.Color.Name;
                    string color = ColorTranslator.ToHtml(Color.FromArgb(colorDialogLed.Color.R, colorDialogLed.Color.G, colorDialogLed.Color.B));
                    //fontColor = colorDialogLed.Color.ToArgb();
                }
            }
            catch (Exception ex) { }
        }

        private void btnAddTxt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLEDId.SelectedValue.ToString()) || string.IsNullOrEmpty(cmbShowType.SelectedValue.ToString()))
            {
                MessageBox.Show("请完善LED信息！");
                return;
            }
            if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))//打开显示屏
            {
                //添加节目
                AddProgram();
                //添加文本
                int postion = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : 0; //左对齐 1居中 2右对齐
                if (LEDShow.AddText(Convert.ToInt32(cmbLEDId.SelectedValue), sWidth, sHeight, txtContent.Text, programInx, Convert.ToInt32(cmbShowType.SelectedValue), fontName, fontSize, fontColor,chkFoild.Checked, postion))
                {
                    MessageBox.Show("添加文本成功！");
                }
                else
                {
                    MessageBox.Show("添加文本失败！");
                    return;
                }
            }
            else
            {
                MessageBox.Show(cmbLEDId.SelectedValue.ToString() + "打开显示屏失败！");
            }
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            if (chkYear.Checked || chkWeek.Checked || chkTime.Checked)
            {
                if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))
                {
                    //添加节目
                    AddProgram();
                    //添加时间
                    if (LEDShow.AddDateTime(Convert.ToInt32(cmbLEDId.SelectedValue), programInx, chkYear.Checked, chkWeek.Checked, chkTime.Checked, fontName, fontSize, fontColor))
                    {
                        MessageBox.Show("添加时间成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加时间失败！");
                    }
                }
                else
                {
                    MessageBox.Show(cmbLEDId.SelectedValue.ToString() + "打开显示屏失败！");
                }
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLEDId.Text))
            {
                MessageBox.Show("请选择指定LED!");
                return;
            }
            if (LEDShow.SendData(Convert.ToInt32(cmbLEDId.SelectedValue)))//发送节目
            {
                MessageBox.Show("发送成功！");
            }
            else
            {
                MessageBox.Show("发送失败！");
            }
        }
        private void AddProgram()
        {
            if (chkDelete.Checked)
            {
                LEDShow.DeleteProgram(Convert.ToInt32(cmbLEDId.SelectedValue));//删除指定控制卡所有节目
            }
            programInx = LEDShow.AddProgram(Convert.ToInt32(cmbLEDId.SelectedValue), 10);
        }

        private void btndefault_Click(object sender, EventArgs e)
        {
            fontSize = 24;
            fontColor = 0x00FF;
            fontName = "宋体";
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

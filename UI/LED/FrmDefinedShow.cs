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
using System.Configuration;

namespace UI
{
    public partial class FrmDefinedShow : Form
    {
        private int programInx = 0;//节目数量
        private int fontSize;//字体大小
        private int fontColor = 0x00FF;//字体颜色
        private string fontName = "宋体";//字体名称
        BllScreeenSetting bllScreeenSetting = new BllScreeenSetting();
        BllLedShowInfo ledShowInfo = new BllLedShowInfo();
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
                cmbShowType.SelectedIndex = 0;
            }
            //屏幕信息
            dtScreen = bllScreeenSetting.GetScreenSetting(string.Empty);
            cmbLEDId.ValueMember = "AddressNum";
            cmbLEDId.DisplayMember = "ScreenID";
            cmbLEDId.DataSource = dtScreen;
            cmbLEDId.SelectedIndex = 0;
        }
        private void btnFontSetting_Click(object sender, EventArgs e)
        {
            if (fontDialogLed.ShowDialog() == DialogResult.OK)
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
                    fontColor = colorDialogLed.Color.ToArgb();
                }
            }
            catch (Exception) { }
        }

        private void btnAddTxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbLEDId.SelectedValue.ToString()) || string.IsNullOrEmpty(cmbShowType.SelectedValue.ToString()))
                {
                    MessageBox.Show("请完善LED信息！");
                    return;
                }
                if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))//打开显示屏
                {
                    AddProgram(); //添加节目
                    int postion = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : 1; //左对齐 1居中 2右对齐  -1不选
                    if (string.IsNullOrEmpty(cmbPosition.Text)) //单行文本不存在位置显示 （左对齐 1居中 2右对齐）
                    {
                        LEDShow.AddSingleText(Convert.ToInt32(cmbLEDId.SelectedValue), sWidth, sHeight, txtContent.Text.Trim(), programInx, Convert.ToInt32(cmbShowType.SelectedValue), fontName, fontSize, 0x00FF, chkFoild.Checked, postion);
                    }
                    else //区域显示
                    {
                        LEDShow.AddText(Convert.ToInt32(cmbLEDId.SelectedValue), sWidth, sHeight, txtContent.Text.Trim(), programInx, Convert.ToInt32(cmbShowType.SelectedValue), fontName, fontSize, 0x00FF, chkFoild.Checked, postion);
                    }
                    MessageBox.Show("添加成功!");
                }
                else
                {
                    MessageBox.Show(cmbLEDId.SelectedValue.ToString() + "打开显示屏失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 控制卡添加节目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTime_Click(object sender, EventArgs e)
        {
            if (chkYear.Checked || chkWeek.Checked || chkTime.Checked)
            {
                if (LEDShow.LedOpen(Convert.ToInt32(cmbLEDId.SelectedValue)))
                {
                    //添加节目
                    AddProgram();
                    //添加时间
                    if (LEDShow.AddDateTime(Convert.ToInt32(cmbLEDId.SelectedValue), programInx, chkYear.Checked, chkWeek.Checked, chkTime.Checked, fontName, fontSize, fontColor,chkLines.Checked))
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
        /// <summary>
        /// 屏幕发送节目显示或是保存到数据库定时发送显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendData_Click(object sender, EventArgs e)
        {
            try
            {
                if (LEDShow.SendData(Convert.ToInt32(cmbLEDId.SelectedValue)))
                {
                    //开始显示日志记录
                    LEDShowInfo showInfo = new LEDShowInfo();
                    showInfo.SendState = "自定义实时发送";
                    showInfo.ScreenId = cmbLEDId.Text;
                    showInfo.AddressNum = Convert.ToInt32(cmbLEDId.SelectedValue);
                    showInfo.Content =string.IsNullOrEmpty(txtContent.Text)? "日期星期时间显示":txtContent.Text;
                    showInfo.FontColor = fontColor.ToString();
                    showInfo.FontName = fontName;
                    showInfo.FontSize = fontSize;
                    showInfo.ShowStyle = Convert.ToInt32(cmbShowType.SelectedValue);
                    showInfo.FontBold = chkFoild.Checked;
                    showInfo.Position = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : 1;
                    showInfo.Duration = Convert.ToInt32(txtTIme.Text);
                    ledShowInfo.InserScreenLog(showInfo);
                    MessageBox.Show("发送成功！");
                }
                else
                {
                    MessageBox.Show("发送失败！");
                }
            }
            catch { }
        }
        private void AddProgram()
        {
            if (string.IsNullOrEmpty(txtTIme.Text))
            {
                MessageBox.Show("输入循环时长!");
                return;
            }
            if (chkDelete.Checked)
            {
                LEDShow.DeleteProgram(Convert.ToInt32(cmbLEDId.SelectedValue));//删除指定控制卡所有节目
            }
            programInx = LEDShow.AddProgram(Convert.ToInt32(cmbLEDId.SelectedValue), Convert.ToInt32(txtTIme.Text));
        }

        private void btndefault_Click(object sender, EventArgs e)
        {
            //fontSize = 24;
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
                        fontSize = Convert.ToInt32(screenRow[0]["FontSize"]);
                    }
                }
            }
            catch (Exception) { }
        }
    }
}

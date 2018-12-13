using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.LED
{
    public partial class FrmByOrderShow : Form
    {
        //private int fontSize = 24;//字体大小
        private string fontName = "宋体";//字体名称
        private string fontColor = "Red";//字体颜色
        BllAreaInfo bllAreaInfo = new BllAreaInfo();//区域
        BllScreen bllScreen = new BllScreen();//屏幕
        BllLedShowInfo ledShowInfo = new BllLedShowInfo();//保存到显示表中
        private Dictionary<string, int> ledInfo = new Dictionary<string, int>();//区域屏幕信息临时缓存
        public FrmByOrderShow()
        {
            InitializeComponent();

            DataTable dtInfo = bllAreaInfo.GetAreaInfo(string.Empty);
            cmbAreaId.ValueMember = "AreaId";
            cmbAreaId.DisplayMember = "AreaName";
            cmbAreaId.DataSource = dtInfo;
            cmbByOrder.SelectedIndex = cmbPosition.SelectedIndex = 0;
        }
        /// <summary>
        /// 设置字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFontSetting_Click(object sender, EventArgs e)
        {
            if (fontDialogled.ShowDialog() == DialogResult.OK)
            {
                //fontSize = Convert.ToInt32(fontDialogled.Font.Size);
                fontName = fontDialogled.Font.Name;
            }
        }
        /// <summary>
        /// 设置字体颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialogLed.ShowDialog() == DialogResult.OK)
            {
                fontColor = colorDialogLed.Color.Name;
            }
        }
        /// <summary>
        /// 保存定时显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbAreaId.Text) && GroupNum.Value > 0 && !string.IsNullOrEmpty(cmbByOrder.Text) && 
                    !string.IsNullOrEmpty(cmbScreens.Text) && !string.IsNullOrEmpty(txtGoupName.Text) && !string.IsNullOrEmpty(txtTIme.Text))
                {
                    if (GroupNum.Value > cmbScreens.Items.Count)
                    {
                        MessageBox.Show("超出屏幕总数!");
                        return;
                    }
                    if (dtpEnd.Value.Hour <= dtpBegin.Value.Hour && dtpEnd.Value.Minute - dtpBegin.Value.Minute < 1)//显示时长提示
                    {
                        MessageBox.Show("设置的显示时间少于1分钟,请重新设置！");
                        return;
                    }
                    if (cmbByOrder.Text.Equals("正序"))
                    {
                        if (cmbScreens.SelectedIndex + GroupNum.Value > cmbScreens.Items.Count)
                        {
                            MessageBox.Show("超出区域屏幕范围!");
                            return;
                        }
                        else
                        {
                            for (int i = 0; i < Convert.ToInt32(GroupNum.Value); i++)
                            {
                                LEDShowInfo lEDShowInfo = new LEDShowInfo();
                                lEDShowInfo.ScreenId = ledInfo.Keys.ToArray()[cmbScreens.SelectedIndex + i];
                                lEDShowInfo.AddressNum = Convert.ToInt32(ledInfo.Values.ToArray()[cmbScreens.SelectedIndex + i]);
                                lEDShowInfo.Content = i.ToString()+"←"+(i + 1).ToString()+"→"+(i + 2).ToString();
                                lEDShowInfo.BeginTime = dtpBegin.Value.ToShortTimeString();
                                lEDShowInfo.EndTime = dtpEnd.Value.ToShortTimeString();
                                lEDShowInfo.FontColor = fontColor;
                                lEDShowInfo.FontName = fontName;
                                //lEDShowInfo.FontSize = fontSize;
                                lEDShowInfo.ShowStyle = 1;
                                lEDShowInfo.Position = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : 1;
                                lEDShowInfo.FontBold = chkFontBold.Checked;
                                lEDShowInfo.Duration = Convert.ToInt32(txtTIme.Text);
                                lEDShowInfo.GroupName = txtGoupName.Text.Trim();
                                lEDShowInfo.DeleteUpProgram = chkDeleteProgram.Checked;
                                ledShowInfo.InsertLedShowInfo(lEDShowInfo);//保存到显示记录表中
                            }
                        }
                    }
                    else if (cmbByOrder.Text.Equals("倒序"))
                    {
                        if (cmbScreens.SelectedIndex + 1 - GroupNum.Value < 0)
                        {
                            MessageBox.Show("超出区域屏幕范围!");
                            return;
                        }
                        else
                        {
                            for (int i = Convert.ToInt32(GroupNum.Value); i > 0; i--)
                            {
                                LEDShowInfo lEDShowInfo = new LEDShowInfo();
                                lEDShowInfo.ScreenId = ledInfo.Keys.ToArray()[cmbScreens.SelectedIndex - Convert.ToInt32(GroupNum.Value) + i];
                                lEDShowInfo.AddressNum = Convert.ToInt32(ledInfo.Values.ToArray()[cmbScreens.SelectedIndex - Convert.ToInt32(GroupNum.Value) + i]);
                                lEDShowInfo.Content =(i + 1).ToString()+ "←" + i.ToString()+ "→" + (i - 1).ToString();
                                lEDShowInfo.BeginTime = dtpBegin.Value.ToShortTimeString();
                                lEDShowInfo.EndTime = dtpEnd.Value.ToShortTimeString();
                                lEDShowInfo.FontColor = fontColor;
                                lEDShowInfo.FontName = fontName;
                                //lEDShowInfo.FontSize = fontSize;
                                lEDShowInfo.ShowStyle = 1;
                                lEDShowInfo.Position = cmbPosition.Text.Equals("居中") ? 1 : cmbPosition.Text.Equals("左对齐") ? 0 : cmbPosition.Text.Equals("右对齐") ? 2 : 0;
                                lEDShowInfo.FontBold = chkFontBold.Checked;
                                lEDShowInfo.Duration = Convert.ToInt32(txtTIme.Text);
                                lEDShowInfo.GroupName = txtGoupName.Text.Trim();
                                lEDShowInfo.DeleteUpProgram = chkDeleteProgram.Checked;
                                ledShowInfo.InsertLedShowInfo(lEDShowInfo);//保存到显示记录表中
                            }
                        }
                    }
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("请继续完善信息！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存错误！"+ex.ToString());
            }
        }
        /// <summary>
        /// 根据选择的区域，筛选对应的屏幕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAreaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAreaId.SelectedValue != null && !string.IsNullOrEmpty(cmbAreaId.Text) && cmbAreaId.SelectedIndex != -1)
            {
                DataTable dtLED = bllScreen.GetScreenInfo($"and  AreaId ='{cmbAreaId.SelectedValue}'");
                ledInfo = new Dictionary<string, int>();
                for (int i = 0; i < dtLED.Rows.Count; i++)
                {
                    ledInfo.Add(dtLED.Rows[i]["ScreenID"].ToString(),Convert.ToInt32(dtLED.Rows[i]["AddressNum"]));
                }
                cmbScreens.DisplayMember = "ScreenID";
                cmbScreens.ValueMember = "AddressNum";
                cmbScreens.DataSource = dtLED;
                cmbScreens.SelectedIndex = -1;
            }
        }
    }
}

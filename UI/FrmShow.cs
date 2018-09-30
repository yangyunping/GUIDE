using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmShow : Form
    {
        BllShowInfo BllShowInfo = new BllShowInfo();
        private readonly string _configPath = Application.StartupPath + @"\\" + @"Config.ini";//配置文件存放路径
        Dictionary<string, DateTime> showInfo = new Dictionary<string, DateTime>();
        private List<ShowContent> showContents = new List<ShowContent>();//已显示的内容临时保存
        public FrmShow()
        {
            InitializeComponent();
            tsbBegin.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.开始);
            tsbEnd.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.停止);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(ShowBegin);
            ShowBegin();
        }
        private void ShowBegin()
        {
            try
            {
                //获取设置的显示顺序
                StringBuilder selectOrder = new StringBuilder(255);
                GetOrSetConfig.GetPrivateProfileString("SelectOrder", "SelectOrderValue", " ", selectOrder, 255,
                    _configPath);
                //获取显示信息
                DataTable dtShow = BllShowInfo.GetShowStateInfo(selectOrder.ToString());
                for (int i = 0; i < dtShow.Rows.Count; i++)
                {
                    //判断开始结束时间进行显示
                    if (Convert.ToDateTime(dtShow.Rows[i]["BeginTime"]) <= DateTime.Now && Convert.ToDateTime(dtShow.Rows[i]["EndTime"]) >= DateTime.Now)
                    {
                        if (showInfo.ContainsKey(dtShow.Rows[i]["Id"].ToString()))
                        {
                            continue;
                        }
                        string content = string.Empty;//显示的序号
                        int configNum = Convert.ToInt32(dtShow.Rows[i]["ConfigNum"]);

                        //列表
                        Panel panel = new Panel() { Dock = DockStyle.Top,Height = 70 };
                        if (Convert.ToInt32(dtShow.Rows[i]["ByOrder"]) == 0)//顺序
                        {
                            for (int j = 0; j < configNum; j++)
                            {
                                content += (j + 1) +",";
                            }
                            panel.BackColor = Color.FromArgb(224 + i * 3, 224, 224);
                        }
                        else
                        {
                            for (int j = configNum; 0 < j; j--)//倒序
                            {

                                content += j + ",";
                            }
                            panel.BackColor = Color.FromArgb(224, 224 + i * 3, 224 + i * 3);
                        }
                        string order = Convert.ToInt32(dtShow.Rows[i]["ByOrder"]) == 0 ? "正序" : "倒序";
                        Label label = new Label() { Dock = DockStyle.Bottom, Font = new Font("微软雅黑", 13), Height = 70 };
                        label.Text = "区域：" + dtShow.Rows[i]["AreaName"].ToString() + "     配置编号 " + dtShow.Rows[i]["ConfigName"].ToString()
                            + "    时间段：" + dtShow.Rows[i]["BeginTime"].ToString() + "-" + dtShow.Rows[i]["EndTime"].ToString() + "   编组：" 
                            + configNum + "     开始屏幕：" + dtShow.Rows[i]["ScreenID"].ToString() + "     顺序：" + order + "     序号：" + content.Remove(content.LastIndexOf(","), 1);
                        showInfo.Add(dtShow.Rows[i]["Id"].ToString(), Convert.ToDateTime(dtShow.Rows[i]["BeginTime"]));

                        //已显示的内容临时保存
                        ShowContent showContent = new ShowContent()
                        {
                            AreaName = dtShow.Rows[i]["AreaName"].ToString(),
                            ConfigName = dtShow.Rows[i]["ConfigName"].ToString(),
                            GroupNum = configNum,
                            BeginTime =dtShow.Rows[i]["BeginTime"].ToString(),
                            EndTime = dtShow.Rows[i]["EndTime"].ToString(),
                            Content = content.Remove(content.LastIndexOf(","), 1),
                            ScreenID = Convert.ToInt32(dtShow.Rows[i]["ScreenID"]),
                            ByOrder = Convert.ToInt32(dtShow.Rows[i]["ByOrder"])
                        };
                        if (!showContents.Contains(showContent))
                        {
                            showContents.Add(showContent);
                        }
                        panel.Controls.Add(label);
                        panel.Tag = dtShow.Rows[i]["Id"].ToString();
                        pnlContent.Controls.Add(panel);

                        BllShowInfo.UpdateShowState(dtShow.Rows[i]["ID"].ToString(), 1);
                    }
                }

                //如果到了结束时间，显示消失
                for (int i = 0; i < dtShow.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dtShow.Rows[i]["EndTime"]) <= DateTime.Now)
                    {
                        foreach (Panel item in pnlContent.Controls)
                        {
                            if (item.Tag.Equals(dtShow.Rows[i]["ID"].ToString()))
                            {
                                pnlContent.Controls.Remove(item);
                                showInfo.Remove(dtShow.Rows[i]["ID"].ToString());
                                BllShowInfo.UpdateShowState(dtShow.Rows[i]["ID"].ToString(), 2);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                dtShow.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbBegin_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void tsbEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
        /// <summary>
        /// 重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPhoto_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //图例
                Graphics g = pnlPhoto.CreateGraphics();
                Pen pen = new Pen(Color.Red);
                BllScreen bllScreen = new BllScreen();
                for (int i = 0; i < showContents.Count; i++)
                {
                    DataTable dtScreen = bllScreen.GetScreenInfo(showContents[i].AreaName);//查询区域对应的屏幕数量
                    //偶数画框
                    if (i % 2 == 0)
                    {
                        if (showContents[i].ByOrder == 0)
                        {
                            //顺序画屏幕框
                            for (int j = 0; j < dtScreen.Rows.Count; j++)
                            {
                                g.DrawRectangle(pen, 100 + j * 40, 150 * i / 2 + 20, 25, 25);
                                if (j + 1 == showContents[i].ScreenID)
                                {
                                    g.DrawString(showContents[i].Content.Replace(",", "      "), new Font("微软雅黑", 12), Brushes.Black, 105 + j * 40, 150 * i / 2 + 20);
                                }
                            }
                        }
                        else
                        {
                            //倒序画屏幕框
                            for (int j = 0; j < dtScreen.Rows.Count; j++)
                            {
                                g.DrawRectangle(pen, 100 + j * 40, 150 * i / 2 + 20, 25, 25);
                                if (j  == showContents[i].ScreenID - showContents[i].GroupNum)
                                {
                                    g.DrawString(showContents[i].Content.Replace(",", "      "), new Font("微软雅黑", 12), Brushes.Black, 105 + j * 40, 150 * i / 2 + 20);
                                }
                            }
                        }
                        g.DrawRectangle(pen, 100, 150 * i / 2 + 50, 900, 70);
                        g.DrawString("区域：" + showContents[i].AreaName + "    配置编号 " + showContents[i].ConfigName + "   编组：" + showContents[i].GroupNum + "    开始时间：" + showContents[i].BeginTime + "    结束时间：" + showContents[i].EndTime, new Font("微软雅黑", 12), Brushes.Black, 120, 150 * i / 2 + 60);
                    }
                    else //奇数不用画大框
                    {
                        if (showContents[i].ByOrder == 0)
                        {
                            //顺序画屏幕框
                            for (int j = 0; j < dtScreen.Rows.Count; j++)
                            {
                                g.DrawRectangle(pen, 100 + j * 40, 150 * (i - 1) / 2 + 125, 25, 25);
                                if (j + 1 == showContents[i].ScreenID)
                                {
                                    g.DrawString(showContents[i].Content.Replace(",", "      "), new Font("微软雅黑", 12), Brushes.Black, 105 + j * 40, 150 * (i - 1) / 2 + 125);
                                }
                            }
                        }
                        else
                        {
                            //倒序画屏幕框
                            for (int j = 0; j < dtScreen.Rows.Count; j++)
                            {
                                g.DrawRectangle(pen, 100 + j * 40, 150 * (i - 1) / 2 + 125, 25, 25);
                                if (j  == showContents[i].ScreenID - showContents[i].GroupNum)
                                {
                                    g.DrawString(showContents[i].Content.Replace(",", "      "), new Font("微软雅黑", 12), Brushes.Black, 105 + j * 40, 150 * (i - 1) / 2 + 125);
                                }
                            }
                        }
                        g.DrawString("区域：" + showContents[i].AreaName + "    配置编号 " + showContents[i].ConfigName + "   编组：" + showContents[i].GroupNum + "    开始时间：" + showContents[i].BeginTime + "    结束时间：" + showContents[i].EndTime, new Font("微软雅黑", 12), Brushes.Black, 120, 150 * (i - 1) / 2 + 90);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

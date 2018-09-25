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
                        string content = string.Empty;
                        int configNum = Convert.ToInt32(dtShow.Rows[i]["ConfigNum"]);
                        Panel panel = new Panel() { Dock = DockStyle.Top };
                        if (Convert.ToInt32(dtShow.Rows[i]["ByOrder"]) == 0)
                        {
                            for (int j = 0; j < configNum; j++)
                            {
                                content += (j + 1) + " ";
                            }
                            panel.BackColor = Color.FromArgb(224 + i * 3, 224, 224);
                        }
                        else
                        {
                            for (int j = configNum; 0 < j; j--)
                            {

                                content += j + " ";
                            }
                            panel.BackColor = Color.FromArgb(224, 224 + i * 3, 224 + i * 3);
                        }
                        Label label = new Label() { Dock = DockStyle.Top, Font = new Font("微软雅黑", 15), Height = 50 };
                        label.Text = "区域：" + dtShow.Rows[i]["AreaName"].ToString() + "     配置编号 " + dtShow.Rows[i]["ConfigName"].ToString()
                            + "    开始时间：" + dtShow.Rows[i]["BeginTime"].ToString() + "    结束时间：" + dtShow.Rows[i]["EndTime"].ToString() + "      " + content.Remove(content.LastIndexOf(" "), 1);

                        showInfo.Add(dtShow.Rows[i]["Id"].ToString(), Convert.ToDateTime(dtShow.Rows[i]["BeginTime"]));
                        panel.Controls.Add(label);
                        panel.Tag = dtShow.Rows[i]["Id"].ToString();
                        pnlContent.Controls.Add(panel);
                        BllShowInfo.UpdateShowState(dtShow.Rows[i]["ID"].ToString(), 1);
                    }
                }
                tsMenue.Dock = DockStyle.Top;

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
    }
}

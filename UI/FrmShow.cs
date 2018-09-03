using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class FrmShow : Form
    {
        BllShowInfo BllShowInfo = new BllShowInfo();
        public FrmShow()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(ShowBegin);
            ShowBegin();
        }
        private void ShowBegin()
        {
            DataTable dtShow = BllShowInfo.GetShowStateInfo(0);
            for (int i = 0; i < dtShow.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dtShow.Rows[i]["BeginTime"]) <= DateTime.Now)// && Convert.ToDateTime(dtShow.Rows[i]["EndTime"]) >= DateTime.Now
                {
                    string content = string.Empty;
                    int configNum = Convert.ToInt32(dtShow.Rows[i]["ConfigNum"]);
                    Panel panel = new Panel() { Dock = DockStyle.Top };
                    if (Convert.ToInt32(dtShow.Rows[i]["ByOrder"]) == 0)
                    {
                        for (int j = 0; j < configNum; j++)
                        {

                            content += (j + 1) + " ";
                        }
                        panel.BackColor = Color.FromArgb(224+i*3, 224, 224);
                    }
                    else
                    {
                        for (int j = configNum; 0 < j; j--)
                        {

                            content += j + " ";
                        }
                        panel.BackColor = Color.FromArgb(224, 224+i * 3, 224 + i * 3);
                    }
                    Label label = new Label() { Dock = DockStyle.Top ,Font = new System.Drawing.Font("微软雅黑", 15),Height = 50 };
                    label.Text = "区域：" + dtShow.Rows[i]["AreaName"].ToString() +"     配置编号 "+ dtShow.Rows[i]["ConfigName"].ToString() 
                        +"    开始时间："+ dtShow.Rows[i]["BeginTime"].ToString() + "    结束时间：" + dtShow.Rows[i]["EndTime"].ToString() + "      " +content.Remove(content.LastIndexOf(" "), 1);
                    panel.Controls.Add(label);
                    this.Controls.Add(panel);
                    BllShowInfo.UpdateShowState(dtShow.Rows[i]["ID"].ToString());
                }
            }
        }
    }
}

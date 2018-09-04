using BLL;
using MODEL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmMain : Form
    {
        BllAreaInfo BllAreaInfo = new BllAreaInfo();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void AreaShowSearch_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmAreaSearch = new FrmSearchTemplet("区域") { Dock = DockStyle.Fill};
            pnlShow.Controls.Add(frmAreaSearch);
        }

        private void ConfigInfoISearch_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet  frmShowSearch = new FrmSearchTemplet("显示") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmShowSearch);
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
        }

        private void 配置查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSearchTemplet frmShowSearch = new FrmSearchTemplet("配置") { Dock = DockStyle.Fill };
            pnlShow.Controls.Add(frmShowSearch);
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlShow.Controls.Clear();
            FrmSelectShow frmSelectShow = new FrmSelectShow() { Dock = DockStyle.Top};
            pnlShow.Controls.Add(frmSelectShow);
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.ShowDialog();
        }

        private void tsbBegin_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.ShowDialog();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            Application.Exit();
        }
    }
}

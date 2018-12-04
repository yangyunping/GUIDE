using System;
using System.Windows.Forms;
using BLL;
using MODEL;

namespace UI.LED
{
    public partial class FrmShowLogSearch : UserControl
    {
        BllLedShowInfo ledShowInfo = new BllLedShowInfo();
        public FrmShowLogSearch()
        {
            InitializeComponent();
            DgvColumns();
            cmbShowState.SelectedIndex = 0;
        }
        private void DgvColumns()
        {
            dgvTemShow.Columns.AddRange(
            new DataGridViewTextBoxColumn { Name = @"ID", DataPropertyName = @"ID", HeaderText = @"序号", Width = 60,},
            new DataGridViewTextBoxColumn { Name = @"ScreenId", DataPropertyName = @"ScreenId", HeaderText = @"屏幕编号", Width = 100},
            new DataGridViewTextBoxColumn { Name = @"SendState", DataPropertyName = @"SendState", HeaderText = @"状态", Width = 80},
            new DataGridViewTextBoxColumn { Name = @"AddressNum", DataPropertyName = @"AddressNum", HeaderText = @"地址码", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"BeginTime", DataPropertyName = @"BeginTime", HeaderText = @"开始时间", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"EndTime", DataPropertyName = @"EndTime", HeaderText = @"结束时间", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"Duration", DataPropertyName = @"Duration", HeaderText = @"循环时长", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"FontName", DataPropertyName = @"FontName", HeaderText = @"字体名称", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"FontSize", DataPropertyName = @"FontSize", HeaderText = @"字体大小", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"FontColor", DataPropertyName = @"FontColor", HeaderText = @"字体颜色", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"ShowStyle", DataPropertyName = @"ShowStyle", HeaderText = @"播放方式", Width = 100 },
            new DataGridViewTextBoxColumn { Name = @"Content", DataPropertyName = @"Content", HeaderText = @"显示内容", Width = 250 },
            new DataGridViewTextBoxColumn { Name = @"CreateDate", DataPropertyName = @"CreateDate", HeaderText = @"创建时间", Width = 100 }
             );
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTemShow.AutoGenerateColumns = false;
            string sKey = string.Empty;
            if (!cmbShowState.Text.Equals("全部"))
            {
                sKey = $@"  and  SendState = '{cmbShowState.Text}'";
            }
            dgvTemShow.DataSource = ledShowInfo.GetShowLog(sKey);
        }

        private void dgvTemShow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex != -1 && dgvTemShow.Columns[e.ColumnIndex].Name == "FontColor")
            {
                e.Value = PublicClass.ColorToText(dgvTemShow.Rows[e.RowIndex].Cells["FontColor"].Value.ToString());//颜色转换为汉语
            }
            else if (dgvTemShow.Columns[e.ColumnIndex].Name == "ShowStyle")
            {
                e.Value = PublicClass.AplayToText(Convert.ToInt32(dgvTemShow.Rows[e.RowIndex].Cells["ShowStyle"].Value));//播放方式转换汉语
            }
        }
    }
}

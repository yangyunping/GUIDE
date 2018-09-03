using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MODEL;
using BLL;

namespace UI
{
    public partial class FrmAddArea : UserControl
    {
        BllAreaInfo bllAreaInfo = new BllAreaInfo();
        public FrmAddArea()
        {
            InitializeComponent();
        }
        public FrmAddArea(AreaInfo areaInfo)
        {
            InitializeComponent();
            txtAreaId.Text = areaInfo.AreaName;
            txtAreaId.ReadOnly = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAreaId.Text.Trim()))
            {
                AreaInfo areaInfo = new AreaInfo();
                areaInfo.AreaName = txtAreaId.Text.Trim();
                if (bllAreaInfo.InsertOrModifyArea(areaInfo))
                {
                    MessageBox.Show("添加修改成功！");
                    txtAreaId.Clear();
                }
            }
        }

        private void txtAreaId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(null,null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent)?.Close();
        }
    }
}

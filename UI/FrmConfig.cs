using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmConfig : UserControl
    {
        BllConfig bllConfig = new BllConfig();

        public FrmConfig()
        {
            InitializeComponent();
            IniteData();
            DgvColumns();
        }

        private void IniteData()
        {
            DataTable dtType = bllConfig.GetConfigInfo(null,null,1);
            DataRow newRow = dtType.NewRow();
            newRow["ConfigNO"] = "-1";
            newRow["ConfigValue"] = "全部";
            dtType.Rows.InsertAt(newRow,0);
            cmbStyle.ValueMember = @"ConfigNO";
            cmbStyle.DisplayMember = @"ConfigValue";
            cmbStyle.DataSource = dtType;

            DataTable dtType1 = bllConfig.GetConfigInfo(null,null, 2);
            cmbType.ValueMember = @"ConfigNO";
            cmbType.DisplayMember = @"ConfigValue";
            cmbType.DataSource = dtType1;
        }

        private void DgvColumns()
        {
            dgvShow.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = @"ConfigNO", DataPropertyName = @"ConfigNO", HeaderText = @"配置编号", Width = 120 },
                 new DataGridViewTextBoxColumn { Name = @"ConfigValue", DataPropertyName = @"ConfigValue", HeaderText = @"配置名称", Width = 150 },
                 new DataGridViewTextBoxColumn { Name = @"ParConfigValue", DataPropertyName = @"ParConfigValue", HeaderText = @"上级名称", Width = 150 }
                    );
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvShow.DataSource = null;
            if (string.IsNullOrEmpty(cmbStyle.Text))
            {
                return;
            }
            dgvShow.AutoGenerateColumns = false;
            DataTable dtInfo = bllConfig.GetConfigInfo(null,cmbStyle.SelectedValue.ToString(), 0);
            dgvShow.DataSource = dtInfo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            cmbType.Enabled = true;
            txtContent.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow != null)
            {
                try
                {
                    if (bllConfig.DeleteConfig(dgvShow.CurrentRow.Cells["ConfigNO"].Value.ToString()))
                    {
                        MessageBox.Show(@"删除成功！");
                        dgvShow.Rows.Remove(dgvShow.CurrentRow);
                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void btnAddStyle_Click(object sender, EventArgs e)
        {
            if (btnAddStyle.Text.Equals("新增类别"))
            {
                btnAddStyle.Text = "保存类别";
                txtType.Visible =btnTypeClose.Visible= true;
                return;
            }
            if (string.IsNullOrEmpty(txtType.Text))
            {
                MessageBox.Show(@"请填写需要添加的类别！");
                return;
            }
   
            foreach (DataRowView item in cmbStyle.Items)
            {
                if (item["ConfigValue"].ToString().Equals(txtType.Text.Trim()))
                {
                    MessageBox.Show(@"该类别已添加");
                    return;
                }
            }
            Config config = new Config();
            config.ConfigValue = txtType.Text.Trim();
            config.ParConfigNO = -1;
            config.Tag = 1;
            if (bllConfig.AddOrUpdateConfig(config))
            {
                MessageBox.Show(@"添加成功！");
                btnAddStyle.Text = "新增类别";
                txtType.Clear();
                txtType.Visible = btnTypeClose.Visible = false;
                IniteData();
            }
            else
            {
                MessageBox.Show(@"添加失败，检查后重试！");
            }
        }

        private void txtContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null,null);
            }
        }
         
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvShow.CurrentRow == null)
            {
                return;
            }
            try
            {
                grpAdd.Visible = true;
                DataTable dtInfo = dgvShow.DataSource as DataTable;
                cmbType.SelectedValue =Convert.ToInt32(dtInfo.Select($@"ConfigNO  = '{dgvShow.CurrentRow.Cells["ConfigNO"].Value}'").CopyToDataTable().Rows[0]["ParConfigNO"]);
                cmbType.Enabled = false;
                txtContent.Text = dgvShow.CurrentRow.Cells["ConfigValue"].Value.ToString();
                dtInfo.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbType.Text) || string.IsNullOrEmpty(txtContent.Text.Trim()))
                {
                    MessageBox.Show(@"请补充完成的信息！");
                    return;
                }
                Config config = new Config();
                if (cmbType.Enabled == false)
                {
                    config.ConfigNO = Convert.ToInt32(dgvShow.CurrentRow.Cells["ConfigNO"].Value);
                }
                else
                {
                    config.ConfigNO = -1;
                }
                config.ConfigValue = txtContent.Text.Trim();
                config.ParConfigNO =Convert.ToInt32(cmbType.SelectedValue);
                config.Tag = 0;
                if (bllConfig.AddOrUpdateConfig(config))
                {
                    MessageBox.Show(@"添加修改成功！");
                    txtContent.Clear();
                }
                else
                {
                    MessageBox.Show(@"添加修改失败，请检查！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvShow.AutoGenerateColumns = false;
            DataTable dtConfig = bllConfig.GetConfigInfo(txtKey.Text,cmbStyle.SelectedValue.ToString(),0);
            dgvShow.DataSource = dtConfig;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = false;
        }

        private void btnTypeClose_Click(object sender, EventArgs e)
        {
            btnAddStyle.Text = "新增类别";
            txtType.Clear();
            txtType.Visible = btnTypeClose.Visible = false;
        }
    }
}

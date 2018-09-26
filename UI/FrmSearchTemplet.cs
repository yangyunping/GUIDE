using BLL;
using System;
using System.Data;
using System.Windows.Forms;
using MODEL;
using System.Threading.Tasks;

namespace UI
{
    public partial class FrmSearchTemplet : UserControl
    {
        BllShowInfo bllShowInfo = new BllShowInfo();
        BllAreaInfo bllAreaInfo = new BllAreaInfo();
        BlllConfiguration BlllConfiguration = new BlllConfiguration();
        private string _OperateType;
        public FrmSearchTemplet(string OperateType)
        {
            InitializeComponent();
            _OperateType = OperateType;
            DgvColumns();
        }
       /// <summary>
       /// 初始化列名
       /// </summary>
        private void DgvColumns()
        {
            switch (_OperateType)
            {
                case "区域":
                    dgvContent.Columns.AddRange(
               new DataGridViewTextBoxColumn { Name = @"AreaId", HeaderText = @"编号", DataPropertyName = @"AreaId", Width = 100 },
               new DataGridViewTextBoxColumn { Name = @"AreaName", HeaderText = @"区域名", DataPropertyName = @"AreaName", Width = 150 }
               );
                    btnAdd.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域新增);
                    btnDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域删除);
                    btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域修改);
                    break;
                case "配置":
                    dgvContent.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = @"ConfigName", HeaderText = @"配置编号", DataPropertyName = @"ConfigName", Width = 150 },
                new DataGridViewTextBoxColumn { Name = @"ConfigNum", HeaderText = @"编组", DataPropertyName = @"ConfigNum", Width = 100 }
              );
                    btnAdd.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.编号新增);
                    btnDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.编号删除);
                    btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.编号修改);
                    btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示新增);
                    btnAddShow.Visible = true;
                    break;
                case "显示":
                    dgvContent.Columns.AddRange(
             new DataGridViewTextBoxColumn { Name = @"Id", HeaderText = @"ID", DataPropertyName = @"ID", Width = 40 },
             new DataGridViewTextBoxColumn { Name = @"ConfigName", HeaderText = @"配置编号", DataPropertyName = @"ConfigName", Width = 120 },
             new DataGridViewTextBoxColumn { Name = @"States", HeaderText = @"状态", DataPropertyName = @"States", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"AreaName", HeaderText = @"区域名", DataPropertyName = @"AreaName", Width = 100 },
             new DataGridViewTextBoxColumn { Name = @"ConfigNum", HeaderText = @"编组号", DataPropertyName = @"ConfigNum", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"ByOrders", HeaderText = @"顺序", DataPropertyName = @"ByOrders", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"BeginTime", HeaderText = @"开始时间", DataPropertyName = @"BeginTime", Width = 120 },
             new DataGridViewTextBoxColumn { Name = @"EndTime", HeaderText = @"结束时间", DataPropertyName = @"EndTime", Width = 120 }
              );
                    btnDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示删除);
                    btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示修改);
                    btnAdd.Visible = false;
                    break;
            }
        }
        /// <summary>
        /// 各种类别查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_OperateType)
                {
                    case "区域":
                        DataTable dtArea = bllAreaInfo.GetAreaInfo(txtKey.Text);
                        dgvContent.AutoGenerateColumns = false;
                        dgvContent.DataSource = dtArea;
                        break;
                    case "配置":
                        DataTable dtConfig = BlllConfiguration.GetConfigInfo(txtKey.Text);
                        dgvContent.AutoGenerateColumns = false;
                        dgvContent.DataSource = dtConfig;
                        break;
                    case "显示":
                        DataTable dtShow = bllShowInfo.GetShowInfo(txtKey.Text.Trim());
                        dgvContent.AutoGenerateColumns = false;
                        dgvContent.DataSource = dtShow;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 各种删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContent.CurrentRow != null)
                {
                    switch (_OperateType)
                    {
                        case "区域":
                            if (bllAreaInfo.DeleteArea(dgvContent.CurrentRow.Cells["AreaName"].Value.ToString()))
                            {
                                MessageBox.Show("删除成功！");
                                dgvContent.Rows.Remove(dgvContent.CurrentRow);
                            }
                            else
                            {
                                MessageBox.Show("删除失败！");
                            }
                            break;
                        case "配置":
                            if (BlllConfiguration.DeleteConfig(dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString()))
                            {
                                MessageBox.Show("删除成功！");
                                dgvContent.Rows.Remove(dgvContent.CurrentRow);
                            }
                            else
                            {
                                MessageBox.Show("删除失败！");
                            }
                            break;
                        case "显示":
                            if (bllShowInfo.DeleteShow(dgvContent.CurrentRow.Cells["Id"].Value.ToString()))
                            {
                                MessageBox.Show("删除成功！");
                                dgvContent.Rows.Remove(dgvContent.CurrentRow);
                            }
                            else
                            {
                                MessageBox.Show("删除失败！");
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContent.CurrentRow != null)
                {
                    if (_OperateType.Equals("区域"))
                    {
                        AreaInfo areaInfo = new AreaInfo();
                        areaInfo.AreaName = dgvContent.CurrentRow.Cells["AreaName"].Value.ToString();
                        FrmAddArea frmAddArea = new FrmAddArea(areaInfo);
                        FrmExample frmExample = new FrmExample() { Size = new System.Drawing.Size(frmAddArea.Size.Width, frmAddArea.Size.Height) };
                        frmExample.Controls.Add(frmAddArea);
                        frmExample.ShowDialog();
                    }
                    else if (_OperateType.Equals("配置"))
                    {
                        Configuration configuration = new Configuration();
                        configuration.ConfigName = dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString();
                        configuration.ConfigNum = Convert.ToInt32(dgvContent.CurrentRow.Cells["ConfigNum"].Value);
                        FrmConfigNum frmConfigNumAdd = new FrmConfigNum(configuration);
                        FrmExample frmExample = new FrmExample() { Size = new System.Drawing.Size(frmConfigNumAdd.Size.Width, frmConfigNumAdd.Size.Height) };
                        frmExample.Controls.Add(frmConfigNumAdd);
                        frmExample.ShowDialog();
                    }
                    else if (_OperateType.Equals("显示"))
                    {
                        ShowInfo showInfo = new ShowInfo();
                        showInfo.ID = dgvContent.CurrentRow.Cells["ID"].Value.ToString();
                        showInfo.AreaName = dgvContent.CurrentRow.Cells["AreaName"].Value.ToString();
                        showInfo.ConfigName = dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString();
                        showInfo.ByOrder = dgvContent.CurrentRow.Cells["ByOrders"].Value.ToString().Equals("正序") ? false : true;
                        showInfo.BeginTime = Convert.ToDateTime(dgvContent.CurrentRow.Cells["BeginTime"].Value);
                        showInfo.EndTime = Convert.ToDateTime(dgvContent.CurrentRow.Cells["EndTime"].Value);
                        Configuration configuration = new Configuration();
                        configuration.ConfigName = dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString();
                        configuration.ConfigNum = Convert.ToInt32(dgvContent.CurrentRow.Cells["ConfigNum"].Value);
                        FrmShowSetting frmShowSetting = new FrmShowSetting(showInfo, configuration);
                        frmShowSetting.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("请选中修改!");
                }
                btnSearch_Click(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_OperateType.Equals("区域"))
                {
                    FrmAddArea frmAddArea = new FrmAddArea();
                    FrmExample frmExample = new FrmExample() { Size = new System.Drawing.Size(frmAddArea.Size.Width, frmAddArea.Size.Height) };
                    frmExample.Controls.Add(frmAddArea);
                    frmExample.ShowDialog();
                }
                else if (_OperateType.Equals("配置"))
                {
                    FrmConfigNum frmConfigNumAdd = new FrmConfigNum();
                    FrmExample frmExample = new FrmExample() { Size = new System.Drawing.Size(frmConfigNumAdd.Size.Width, frmConfigNumAdd.Size.Height) };
                    frmExample.Controls.Add(frmConfigNumAdd);
                    frmExample.ShowDialog();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            if (dgvContent.CurrentRow != null)
            {
                Configuration configuration = new Configuration();
                configuration.ConfigName = dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString();
                configuration.ConfigNum = Convert.ToInt32(dgvContent.CurrentRow.Cells["ConfigNum"].Value);
                FrmShowSetting frmShowSetting = new FrmShowSetting(configuration);
                frmShowSetting.ShowDialog();
            }
            else
            {
                MessageBox.Show("选中配置编号再添加！");
            }
        }
    }
}

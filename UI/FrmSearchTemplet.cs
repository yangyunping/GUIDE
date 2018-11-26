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
        BlllConfiguration blllConfiguration = new BlllConfiguration();
        BllScreen bllScreen = new BllScreen();
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
                    grbMenues.Text = "区域设置";
                    dgvContent.Columns.AddRange(
               new DataGridViewTextBoxColumn { Name = @"AreaId", HeaderText = @"编号", DataPropertyName = @"AreaId", Width = 100 },
               new DataGridViewTextBoxColumn { Name = @"AreaName", HeaderText = @"区域名", DataPropertyName = @"AreaName", Width = 150 }
               );
                    btnAdd.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域新增);
                    btnDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域删除);
                    btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.区域修改);
                    break;
                case "配置":
                    grbMenues.Text = "编组设置";
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
                    grbMenues.Text = "显示查询";
                    dgvContent.Columns.AddRange(
             new DataGridViewTextBoxColumn { Name = @"Id", HeaderText = @"ID", DataPropertyName = @"ID", Width = 40 },
             new DataGridViewTextBoxColumn { Name = @"ScreenId", HeaderText = @"屏幕编号", DataPropertyName = @"ScreenId", Width = 120 },
             new DataGridViewTextBoxColumn { Name = @"AreaName", HeaderText = @"区域名", DataPropertyName = @"AreaName", Width = 100 },
             new DataGridViewTextBoxColumn { Name = @"BeginTime", HeaderText = @"开始时间", DataPropertyName = @"AreaName", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"EndTime", HeaderText = @"结束时间", DataPropertyName = @"EndTime", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"Content", HeaderText = @"显示内容", DataPropertyName = @"Content", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"FontName", HeaderText = @"字体名称", DataPropertyName = @"FontName", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"FontColor", HeaderText = @"字体颜色", DataPropertyName = @"FontColor", Width = 120 },
             new DataGridViewTextBoxColumn { Name = @"FontSize", HeaderText = @"字体大小", DataPropertyName = @"FontSize", Width = 120 }
              );
        btnDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示删除);
                    btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示修改);
                    btnAdd.Visible = false;
                    break;
                case "屏幕":
                    grbMenues.Text = "显示器设置";
                    dgvContent.Columns.AddRange(
             new DataGridViewTextBoxColumn { Name = @"ID", HeaderText = @"编号ID", DataPropertyName = @"ID", Width = 80 },
             new DataGridViewTextBoxColumn { Name = @"ScreenID", HeaderText = @"屏幕编号", DataPropertyName = @"ScreenID", Width = 100 },
             new DataGridViewTextBoxColumn { Name = @"AreaId", HeaderText = @"区域编号", DataPropertyName = @"AreaId", Width = 120 },
             new DataGridViewTextBoxColumn { Name = @"AreaName", HeaderText = @"区域名", DataPropertyName = @"AreaName", Width = 120 },
             new DataGridViewTextBoxColumn { Name = @"AddressNum", HeaderText = @"硬件地址码", DataPropertyName = @"AddressNum", Width = 130 },
             new DataGridViewTextBoxColumn { Name = @"OrderNum", HeaderText = @"顺序", DataPropertyName = @"OrderNum", Width = 100 }
              );
                    DataTable dtAre = bllAreaInfo.GetAreaInfo(string.Empty);
                    DataRow newRow = dtAre.NewRow();
                    newRow["AreaId"] = -1;
                    newRow["AreaName"] = "全部";
                    dtAre.Rows.InsertAt(newRow,0);
                    cmbArea.ValueMember = "AreaId";
                    cmbArea.DisplayMember = "AreaName";
                    cmbArea.DataSource = dtAre;
                    lblArea.Visible = cmbArea.Visible = true;
                    btnAddShow.Visible = lblKey.Visible = txtKey.Visible = false;
                    btnAdd.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示器新增);
                    btnModify.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示器修改);
                    btnDelete.Enabled = CurrentInfo.currentPowers.ContainsKey(CommonInfo.显示器删除);
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
                        DataTable dtConfig = blllConfiguration.GetConfigInfo(txtKey.Text);
                        dgvContent.AutoGenerateColumns = false;
                        dgvContent.DataSource = dtConfig;
                        break;
                    case "显示":
                        DataTable dtShow = bllShowInfo.GetShowInfo(txtKey.Text.Trim());
                        dgvContent.AutoGenerateColumns = false;
                        dgvContent.DataSource = dtShow;
                        break;
                    case "屏幕":
                        string key = string.Empty;
                        if (!cmbArea.Text.Equals("全部"))
                        {
                            key = cmbArea.SelectedValue.ToString();
                        }
                        DataTable dtScreen = bllScreen.GetScreenInfo(key);
                        dgvContent.AutoGenerateColumns = false;
                        dgvContent.DataSource = dtScreen;
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
                            if (blllConfiguration.DeleteConfig(dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString()))
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
                        case "屏幕":
                            if (bllScreen.DeleteScreen(dgvContent.CurrentRow.Cells["ID"].Value.ToString()))
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
                        areaInfo.AreaId = Convert.ToInt32(dgvContent.CurrentRow.Cells["AreaId"].Value);
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
                        showInfo.ID =Convert.ToInt32(dgvContent.CurrentRow.Cells["ID"].Value);
                        showInfo.AreaName = dgvContent.CurrentRow.Cells["AreaName"].Value.ToString();
                        showInfo.ConfigName = dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString();
                        showInfo.ByOrder = dgvContent.CurrentRow.Cells["ByOrders"].Value.ToString().Equals("正序") ? false : true;
                        showInfo.BeginTime = Convert.ToDateTime(dgvContent.CurrentRow.Cells["BeginTime"].Value);
                        showInfo.EndTime = Convert.ToDateTime(dgvContent.CurrentRow.Cells["EndTime"].Value);
                        showInfo.ScreenId = Convert.ToInt32(dgvContent.CurrentRow.Cells["ScreenId"].Value);
                        Configuration configuration = new Configuration();
                        configuration.ConfigName = dgvContent.CurrentRow.Cells["ConfigName"].Value.ToString();
                        configuration.ConfigNum = Convert.ToInt32(dgvContent.CurrentRow.Cells["ConfigNum"].Value);
                        FrmShowSetting frmShowSetting = new FrmShowSetting(showInfo, configuration);
                        frmShowSetting.ShowDialog();
                    }
                    else if (_OperateType.Equals("屏幕"))
                    {
                        Screens screens = new Screens();
                        screens.ID = Convert.ToInt32(dgvContent.CurrentRow.Cells["ID"].Value);
                        screens.ScreenID =dgvContent.CurrentRow.Cells["ScreenID"].Value.ToString();
                        screens.AreaID = Convert.ToInt32(dgvContent.CurrentRow.Cells["AreaID"].Value);
                        screens.AddressNum = Convert.ToInt32(dgvContent.CurrentRow.Cells["AddressNum"].Value);
                        FrmSreen frmSreen = new FrmSreen(screens);
                        FrmExample frmExample = new FrmExample() { Size = new System.Drawing.Size(frmSreen.Size.Width, frmSreen.Size.Height) };
                        frmExample.Controls.Add(frmSreen);
                        frmExample.ShowDialog();
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
                else if (_OperateType.Equals("屏幕"))
                {
                    FrmSreen frmSreen = new FrmSreen(null);
                    FrmExample frmExample = new FrmExample() { Size = new System.Drawing.Size(frmSreen.Size.Width, frmSreen.Size.Height) };
                    frmExample.Controls.Add(frmSreen);
                    frmExample.ShowDialog();
                }
                btnSearch_Click(null, null);
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

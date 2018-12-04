using BLL;
using MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmSearchTemplet : UserControl
    {
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
                    case "屏幕":
                        string key = string.Empty;
                        if (!cmbArea.Text.Equals("全部"))
                        {
                            key = $"and  AreaId ='{cmbArea.SelectedValue}'";
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
                    else if (_OperateType.Equals("屏幕"))
                    {
                        ScreensToArea screens = new ScreensToArea();
                        screens.ID = Convert.ToInt32(dgvContent.CurrentRow.Cells["ID"].Value);
                        screens.ScreenID =dgvContent.CurrentRow.Cells["ScreenID"].Value.ToString();
                        screens.AreaID = Convert.ToInt32(dgvContent.CurrentRow.Cells["AreaID"].Value);
                        FrmSreenToArea frmSreen = new FrmSreenToArea(screens);
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
                else if (_OperateType.Equals("屏幕"))
                {
                    FrmSreenToArea frmSreen = new FrmSreenToArea(null);
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
    }
}

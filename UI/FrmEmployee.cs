using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BLL;
using MODEL;

namespace UI
{
    public partial class FrmEmployee : Form
    {
        BllEmployee bllEmployee = new BllEmployee();
        BllEmpPowers bllEmpPowers = new BllEmpPowers();
        BllConfig bllConfig = new BllConfig();
        private readonly Employee _employee;
        public FrmEmployee(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            IniteData();
        }

        private void IniteData()
        {
            DataTable dtPower = bllConfig.GetConfigInfo(bllConfig.GetConfigInfo(CommonInfo.Types.权限.ToString(), 0).Rows[0]["ConfigNO"].ToString(),1);
            for (int i = 0; i < dtPower.Rows.Count; i++)
            {
                twPower.Nodes.Add(dtPower.Rows[i]["ConfigNO"].ToString(), dtPower.Rows[i]["ConfigValue"].ToString());
            }
            dtPower.Dispose();

            if (_employee != null)
            {
                txtID.Text = _employee.EmployeeNo;
                txtID.ReadOnly = true;
                txtName.Text = _employee.EmployeeName;
                txtPhoneNum.Text = _employee.MoblePhone;
                cmbGender.Text = _employee.Gender;
                txtAge.Text = _employee.Age;
            }
            DataTable dtEmpPower = bllEmpPowers.GetEmpPowers(CurrentInfo.currentEmp.EmployeeNo);
            foreach (DataRow t in dtEmpPower.Rows)
            {
                foreach (TreeNode treeNode in twPower.Nodes)
                {
                    if (treeNode.Name == t["PowerName"].ToString())
                    {
                        treeNode.Checked = true;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"请完善人员全部信息！");
                return;
            }
            try
            {
                List<string> lstEmp = (from TreeNode treeNode in twPower.Nodes where treeNode.Checked select treeNode.Name).ToList();
                if (lstEmp.Count == 0)
                {
                    MessageBox.Show(@"请勾选该员工的权限后保存！");
                    return;
                }
                //ErpServer.DeletePower(txtID.Text);
                //if (ErpServer.InsertEmpInfo(txtID.Text, txtName.Text, txtPassword.Text, cmbGender.Text, txtAge.Text, txtPhoneNum.Text,
                //    cmbDuty.SelectedValue.ToString(), lstEmp))
                //{
                //    MessageBox.Show(@"保存成功！");
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show(@"保存失败，检查后重试！");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"年龄、电话号码都为纯数字，请检查!" + ex);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void twPower_AfterSelect(object sender, TreeViewEventArgs e)
        {
            twPower.SelectedNode.Checked = !twPower.SelectedNode.Checked;
        }
    }
}

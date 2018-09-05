﻿using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
            try
            {
                if (bllConfig.GetConfigInfo(CommonInfo.Types.权限.ToString(), null, 1).Rows.Count != 0)
                {
                    DataTable dtPower = bllConfig.GetConfigInfo(null, bllConfig.GetConfigInfo(CommonInfo.Types.权限.ToString(), null, 1).Rows[0]["ConfigNO"].ToString(), 0);
                    for (int i = 0; i < dtPower.Rows.Count; i++)
                    {
                        TreeNode treeNode = new TreeNode()
                        {
                            Name = dtPower.Rows[i]["ConfigNO"].ToString(),
                            Text = dtPower.Rows[i]["ConfigValue"].ToString()
                        };
                        DataTable dtsonPower = bllConfig.GetConfigInfo(null, dtPower.Rows[i]["ConfigNO"].ToString(), 0);
                        for (int j = 0; j < dtsonPower.Rows.Count; j++)
                        {
                            treeNode.Nodes.Add(dtsonPower.Rows[j]["ConfigNO"].ToString(), dtsonPower.Rows[j]["ConfigValue"].ToString());
                        }
                        twPower.Nodes.Add(treeNode);
                        dtsonPower.Dispose();
                    }
                    dtPower.Dispose();

                }
                if (_employee != null)
                {
                    txtID.Text = _employee.EmployeeNo;
                    txtID.ReadOnly = true;
                    txtName.Text = _employee.EmployeeName;
                    txtPhoneNum.Text = _employee.MoblePhone;
                    cmbGender.Text = _employee.Gender;
                    txtAge.Text = _employee.Age.ToString();

                    DataTable dtEmpPower = bllEmpPowers.GetEmpPowers(CurrentInfo.currentEmp.EmployeeNo);
                    foreach (DataRow t in dtEmpPower.Rows)
                    {
                        foreach (TreeNode treeNode in twPower.Nodes)
                        {
                            if (treeNode.Name == t["PowerNo"].ToString())
                            {
                                treeNode.Checked = true;
                            }
                        }
                    }
                    dtEmpPower.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                List<EmpPowers> lstEmp = new List<EmpPowers>();
                foreach (TreeNode treeNode in twPower.Nodes)
                {
                    if (treeNode.Checked)
                    {
                        EmpPowers empPowers = new EmpPowers();
                        empPowers.EmployeeNo = txtID.Text;
                        empPowers.PowerNo = treeNode.Name;
                        lstEmp.Add(empPowers);
                    }
                }
                if (lstEmp.Count == 0)
                {
                    MessageBox.Show(@"请勾选该员工的权限后保存！");
                    return;
                }
                Employee employee = new Employee();
                employee.EmployeeNo = txtID.Text.Trim();
                employee.EmployeeName = txtName.Text.Trim();
                employee.Gender = cmbGender.Text;
                employee.Age = Convert.ToInt32(txtAge.Text);
                employee.MoblePhone = txtPhoneNum.Text;
                if (bllEmployee.AddOrUpdateEmp(employee))
                {
                    bllEmpPowers.DeleteEmpPowers(txtID.Text.Trim());
                    bllEmpPowers.InserEmpPower(lstEmp);
                    MessageBox.Show(@"保存成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(@"保存失败，检查后重试！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"信息有误，请检查后重试!" + ex);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void twPower_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (twPower.SelectedNode != null)
            {
                twPower.SelectedNode.Checked = !twPower.SelectedNode.Checked;
            }
        }

        private void twPower_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (!e.Node.Checked)
                {
                    foreach (TreeNode item in e.Node.Nodes)
                    {
                        item.Checked = e.Node.Checked;
                    }
                    return;
                }
                if (e.Node.Parent != null)
                {
                    foreach (TreeNode item in e.Node.Parent.Nodes)
                    {
                        if (item.Checked)
                        {
                            e.Node.Parent.Checked = true;
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            } 
        }
    }
}

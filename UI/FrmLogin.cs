using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmLogin : Form
    {
        private Point _mousePoint;
        /// <summary>
        /// 最多允许记录的用户名个数
        /// </summary>
        private const int MaxLoginNameSaveCount = 10;
        /// <summary>
        /// 记录的用户名用到的注册表信息键值
        /// </summary>
        private const string RegisterValueName = @"LoginName";
        /// <summary>
        /// 记录的用户名用到的注册表信息路径
        /// </summary>
        private  readonly Model.Registry ResistryKey = new Model.Registry(@"HKEY_CURRENT_USER\software\MedicalManage\");
        public FrmLogin()
        {
            InitializeComponent();
            InitiLogin();
        }
        public bool ThumbnailCallback()
        {
            return false;
        }

        private void InitiLogin()
        {
            this.MouseDown += (sender, e) => _mousePoint = e.Location;
            lblClose.MouseMove += (sender, args) => lblClose.BackColor = Color.Red;
            lblClose.MouseLeave += (sender, args) => lblClose.BackColor = Color.Transparent;
            this.AcceptButton = btnLogin;
            this.MouseMove += (sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Location = new Point(Location.X + e.X - _mousePoint.X, Location.Y + e.Y - _mousePoint.Y);
                }
            };
            string[] registry = ResistryKey.GetRegistry(RegisterValueName);
            if (null == registry)
            {
                cmbEmpID.Focus();
                return;
            }
            else
            {
                cmbEmpID.Items.AddRange(registry);
                cmbEmpID.SelectedIndex = 0;
                txtPassword.Focus();
            }
        }

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush myBrush = new LinearGradientBrush(ClientRectangle, Color.LightSkyBlue, Color.White, LinearGradientMode.Vertical);
            g.FillRectangle(myBrush, ClientRectangle);
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbEmpID.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"请输入账号和密码！");
                return;
            }
            BllServer bllServer = new BllServer();
            BllEmployee bllEmployee = new BllEmployee();
            BllEmpPowers bllEmpPowers = new BllEmpPowers();
            try
            {
                if (bllServer.TestConnection())
                {
                    using (DataTable dtUser = bllEmployee.GetEmployeeInfo(cmbEmpID.Text, 0))
                    {
                        if (dtUser == null)
                        {
                            MessageBox.Show(@"工号输入错误或不存在该人员工号！");
                            cmbEmpID.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            cmbEmpID.Focus();
                            return;
                        }
                        if (dtUser.Rows.Count == 0)
                        {
                            MessageBox.Show(@"没有创建该工号！");
                            cmbEmpID.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            cmbEmpID.Focus();
                            return;
                        }
                        if (!dtUser.Rows[0]["Password"].ToString().Equals(txtPassword.Text))
                        {
                            MessageBox.Show(@"密码错误，请重新输入！");
                            txtPassword.Text = string.Empty;
                            txtPassword.Focus();
                            return;
                        }
                        if (chkRemember.Checked)
                        {
                            //记住用户名
                            string strLoginName = cmbEmpID.Text;
                            List<string> lstLoginName = new List<string>
                                            {
                                                    strLoginName
                                            };
                            string[] registry = ResistryKey.GetRegistry(RegisterValueName);
                            if (null != registry)
                            {
                                foreach (string name in registry.TakeWhile(name => lstLoginName.Count < MaxLoginNameSaveCount).Where(name => 0 != StringComparer.CurrentCulture.Compare(strLoginName.ToUpper(), name.ToUpper())))
                                    lstLoginName.Add(name);
                            }
                            ResistryKey.SetRegistry(RegisterValueName, lstLoginName.ToArray());
                        }
                        //保存用户信息
                        Employee employee = new Employee();
                        employee.EmployeeNo = dtUser.Rows[0]["EmployeeNo"].ToString();
                        employee.EmployeeName = dtUser.Rows[0]["EmployeeName"].ToString();
                        employee.Age = Convert.ToInt32(dtUser.Rows[0]["Age"]);
                        employee.Gender = dtUser.Rows[0]["Gender"].ToString();
                        employee.MoblePhone = dtUser.Rows[0]["MoblePhone"].ToString();
                        employee.PassWord = dtUser.Rows[0]["PassWord"].ToString();
                        CurrentInfo.currentEmp = employee;
                        dtUser.Dispose();

                        //用户权限
                        Dictionary<int, string> empPowersLst = new Dictionary<int, string>();
                        DataTable dtPower = bllEmpPowers.GetEmpPowers(cmbEmpID.Text);
                        for (int i = 0; i < dtPower.Rows.Count; i++)
                        {
                            if (!empPowersLst.ContainsKey(Convert.ToInt32(dtPower.Rows[i]["PowerNo"])))
                            {
                                empPowersLst.Add(Convert.ToInt32(dtPower.Rows[i]["PowerNo"]), dtPower.Rows[i]["EmployeeNo"].ToString());
                            }
                        }
                        CurrentInfo.currentPowers = empPowersLst;
                        dtPower.Dispose();
                        //List<EmpPowers> empPowersLst = new List<EmpPowers>();
                        //DataTable dtPower = bllEmpPowers.GetEmpPowers(cmbEmpID.Text);
                        //for (int i = 0; i < dtPower.Rows.Count; i++)
                        //{
                        //    EmpPowers empPowers = new EmpPowers();
                        //    empPowers.EmployeeNo = dtPower.Rows[0]["EmployeeNo"].ToString();
                        //    empPowers.PowerNo = dtPower.Rows[0]["PowerNo"].ToString();
                        //    empPowersLst.Add(empPowers);
                        //}
                      

                        FrmMain frmMain = new FrmMain();
                        this.Hide();
                        frmMain.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show(@"网络连接失败，检查网络后重试！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}

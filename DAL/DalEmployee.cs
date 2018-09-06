using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DalEmployee
    {
        Server server = new Server();
        /// <summary>
        /// 获取员工基本信息
        /// </summary>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public DataTable GetEmployeeInfo(string sKey)
        {
            string sSql = $@"Select * from Employee where IsDelete = 0  {sKey}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 添加修改员工
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool AddOrUpdateEmp(Employee employee)
        {
            string sSql = $@"
IF EXISTS(Select * from Employee where EmployeeNo = '{employee.EmployeeNo}')
BEGIN
Update Employee set EmployeeName = '{employee.EmployeeName}',MoblePhone = '{employee.MoblePhone}',Age = '{employee.Age}',Gender = '{employee.Gender}' where EmployeeNo = '{employee.EmployeeNo}'
END
ELSE
BEGIN
Insert into Employee(EmployeeNo,EmployeeName,MoblePhone,Age,Gender) values('{employee.EmployeeNo}','{employee.EmployeeName}','{employee.MoblePhone}','{employee.Age}','{employee.Gender}')
END";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        public bool DeleteEmployee(string empNo)
        {
            string sSql = $@" Update Employee set Isdelete = 1 where EmployeeNo = '{empNo}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        public bool UpdatePwd(string empNo,string password)
        {
            string sSql = $@" Update Employee set PassWord = '{password}' where EmployeeNo = '{empNo}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

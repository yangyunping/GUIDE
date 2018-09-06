using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;
using MODEL;

namespace BLL
{
    public class BllEmployee
    {
        DalEmployee DalEmployee = new DalEmployee();
        public DataTable GetEmployeeInfo(string sKey,int type)
        {
            string sSql = string.Empty;
            switch (type)
            {
                case 0:
                    sSql = $@"  and  EmployeeNo = '{sKey}'";
                    break;
                case 1:
                    if (!string.IsNullOrEmpty(sKey))
                    {
                        sSql = $@"  and  (EmployeeName like '{sKey}%' or  EmployeeNo like '{sKey}%')";
                    }
                    break;
            }
            return DalEmployee.GetEmployeeInfo(sSql);
        }
        public bool AddOrUpdateEmp(Employee employee)
        {
            return DalEmployee.AddOrUpdateEmp(employee);
        }
        public bool DeleteEmployee(string empNo)
        {
            return DalEmployee.DeleteEmployee(empNo);
        }
        public bool UpdatePwd(string empNo, string password)
        {
            return DalEmployee.UpdatePwd(empNo, password);
        }
    }
}

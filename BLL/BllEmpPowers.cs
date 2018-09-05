using DAL;
using MODEL;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BllEmpPowers
    {
        DalEmpPowers DalEmpPowers = new DalEmpPowers();
        public DataTable GetEmpPowers(string empNo)
        {
            string sSql = $@" and EmployeeNo = '{empNo}'";
            return DalEmpPowers.GetEmpPowers(sSql);
        }
        public bool InserEmpPower(List<EmpPowers> empPowers)
        {
            return DalEmpPowers.InserEmpPower(empPowers);
        }
        public bool DeleteEmpPowers(string empNo)
        {
            return DalEmpPowers.DeleteEmpPowers(empNo);
        }
    }
}

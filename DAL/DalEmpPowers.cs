using MODEL;
using System.Data;

namespace DAL
{
    public class DalEmpPowers
    {
        Server server = new Server();
        /// <summary>
        /// 获取员工权限
        /// </summary>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public DataTable GetEmpPowers(string sKey)
        {
            string sSql = $@"Select * from EmpPowers where 1=1  {sKey}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 添加员工权限
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool InserEmpPower(EmpPowers empPowers)
        {
            string sSql = $@"
Insert into EmpPowers(EmployeeNo,PowerNo) values('{empPowers.EmployeeNo}','{empPowers.PowerNo}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 删除员工权限
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        public bool DeleteEmpPowers(string empNo)
        {
            string sSql = $@" Delete from  EmpPowers where EmployeeNo = '{empNo}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

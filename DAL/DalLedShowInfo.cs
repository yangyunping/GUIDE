using MODEL;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 定时显示表
    /// </summary>
    public class DalLedShowInfo
    {
        Server server = new Server();
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteLedShowInfo(int id)
        {
            string sSql = $@"Delete from LEDShowInfo where ID = '{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetLEDShowInfos(string key)
        {
            string sSql = $@"select * from LEDShowInfo where 1=1 {key}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
    }
}

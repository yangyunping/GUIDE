using MODEL;
using System.Data;

namespace DAL
{
    public class DalConfig
    {
        Server server = new Server();
        /// <summary>
        /// 获取员工基本信息
        /// </summary>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public DataTable GetConfigInfo(string sKey)
        {
            string sSql = $@"Select * from View_Config where 1=1 {sKey}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 添加修改员工
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool AddOrUpdateConfig(Config config)
        {
            string sSql = $@"
IF EXISTS( Select * from Config where ConfigNO = '{config.ConfigNO}')
BEGIN
 Update Config set ConfigValue = '{config.ConfigValue}',ParConfigNO = '{config.ParConfigNO}',Tag = '{config.Tag}' where ConfigNO = '{config.ConfigNO}'
END
ELSE
BEGIN
 Insert Into Config(ConfigValue,ParConfigNO,Tag) values('{config.ConfigValue}','{config.ParConfigNO}','{config.Tag}')
END";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        public bool DeleteConfig(string configNo)
        {
            string sSql = $@"  Delete from Config where ConfigNO = '{configNo}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

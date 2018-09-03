using System.Data;
using MODEL;

namespace DAL
{
    public class DalConfiguration
    {
        Server server = new Server();
        /// <summary>
        /// 获取配置信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetConfigInfo(string key)
        {
            string sSql = $@"Select * from Configuration where 1=1   ";
            if (!string.IsNullOrEmpty(key))
            {
                sSql += $@"  and  ConfigName like '%{key}%'";
            }
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 删除配置
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteConfig(string configName)
        {
            string sSql = $@"Delete from Configuration where ConfigName = '{configName}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 添加修改配置
        /// </summary>
        /// <param name="showInfo"></param>
        /// <returns></returns>
        public bool InsertOrModifyConfig(Configuration configuration)
        {
            string sSql = $@"
IF NOT EXISTS(Select * from Configuration where ConfigName = '{configuration.ConfigName}')
BEGIN
Insert into Configuration(ConfigName,ConfigNum) values('{configuration.ConfigName}','{configuration.ConfigNum}')
END
ELSE
BEGIN
Update Configuration set ConfigNum = '{configuration.ConfigNum}'  where ConfigName = '{configuration.ConfigName}'
END
";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

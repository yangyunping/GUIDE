using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalScreen
    {
        Server server = new Server();
        /// <summary>
        /// 获取区域信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetScreenInfo(string key)
        {
            string sSql = $@"Select * from Screen where 1=1";
            if (!string.IsNullOrEmpty(key))
            {
                sSql += $@"  and AreaName like '%{key}%'";
            }
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 删除区域
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteScreen(string screenID)
        {
            string sSql = $@"Delete from Screen where ScreenID = '{screenID}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 修改添加区域编号
        /// </summary>
        /// <param name="showInfo"></param>
        /// <returns></returns>
        public bool InsertOrModifyScreen(Screen screen)
        {
            string sSql = $@"
IF NOT EXISTS(Select * from Screen where ScreenID = '{screen.ScreenID}')
BEGIN
Insert into Screen(AreaName,AddressNum) values('{screen.AreaName}')
END
ELSE
BEGIN
Update Screen set AreaName = '{screen.AreaName}',AddressNum = '{screen.AddressNum}' where ScreenID = '{screen.ScreenID}'
END";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

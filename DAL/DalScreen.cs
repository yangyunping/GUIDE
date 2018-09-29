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
        public bool DeleteScreen(string ID)
        {
            string sSql = $@"Delete from Screen where  ID = '{ID}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 修改添加区域编号
        /// </summary>
        /// <param name="showInfo"></param>
        /// <returns></returns>
        public bool InsertOrModifyScreen(Screens screen)
        {
            string sSql = $@"
IF NOT EXISTS(Select * from Screen where ID = '{screen.ID}')
BEGIN
Insert into Screen(AreaName,AddressNum,ScreenID) values('{screen.AreaName}','{screen.AddressNum}','{screen.ScreenID}')
END
ELSE
BEGIN
Update Screen set AreaName = '{screen.AreaName}',AddressNum = '{screen.AddressNum}',ScreenID ='{screen.ScreenID}'  where ID = '{screen.ID}'
END";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

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
            string sSql = $@"Select * from View_LED where 1=1";
            if (!string.IsNullOrEmpty(key))
            {
                sSql += $@"  and  AreaId ='{key}' order by OrderNum";
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
declare @OrderNum int
select @OrderNum =ISNULL(MAX(OrderNum)+1,1) from Screen where AreaID = '{screen.AreaID}'
IF NOT EXISTS(Select * from Screen where ID = '{screen.ID}')
BEGIN
Insert into Screen(AreaID,AddressNum,ScreenID,OrderNum) values('{screen.AreaID}','{screen.AddressNum}','{screen.ScreenID}',@OrderNum)
END
ELSE
BEGIN
Update Screen set  AddressNum = '{screen.AddressNum}',ScreenID ='{screen.ScreenID}'  where  ID  = '{screen.ID}'
END";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalScreenToArea
    {
        Server server = new Server();
        /// <summary>
        /// 获取区域信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetScreenInfo(string key)
        {
            string sSql = $@"Select * from View_SreensToArea where 1=1 {key} order by OrderNum";
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 删除区域
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteScreen(string ID)
        {
            string sSql = $@"Delete from ScreenToArea where  ID = '{ID}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 修改添加区域编号
        /// </summary>
        /// <param name="showInfo"></param>
        /// <returns></returns>
        public bool InsertOrModifyScreen(ScreensToArea screen)
        {
            string sSql = $@"
declare @OrderNum int
select @OrderNum =ISNULL(MAX(OrderNum)+1,1) from ScreenToArea where AreaID = '{screen.AreaID}'
IF NOT EXISTS(Select * from ScreenToArea where ID = '{screen.ID}')
BEGIN
Insert into ScreenToArea(AreaID,ScreenID,OrderNum) values('{screen.AreaID}','{screen.ScreenID}',@OrderNum)
END
ELSE
BEGIN
Update ScreenToArea set ScreenID ='{screen.ScreenID}'  where  ID  = '{screen.ID}'
END";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

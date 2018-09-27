using System.Data;
using MODEL;

namespace DAL
{
    public class DalShowInfo
    {
        Server server = new Server();
        /// <summary>
        /// 获取临时设置显示数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetShowInfo(string key)
        {
            string sSql = $@"Select case ByOrder when 0 then '正序' when 1 then '倒序' end as ByOrders,case State when 0 then '等待' when 1 then '进行中' when 2 then '结束' end as States, * from  View_ConfigNum  where 1=1 ";
            if (!string.IsNullOrEmpty(key))
            {
                sSql += $@"  {key}";
            }
            return server.ExecuteQuery(sSql).Tables[0];
        }
        /// <summary>
        /// 删除临时设置显示数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteShow(string id)
        {
            string sSql = $@"Delete from ShowInfo where Id = '{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 记录修改临时设置显示数据
        /// </summary>
        /// <param name="showInfo"></param>
        /// <returns></returns>
        public bool InsertOrModifyShow(ShowInfo showInfo)
        {
            string sSql = $@"
IF NOT EXISTS(Select * from ShowInfo where Id = '{showInfo.ID}')
BEGIN
Insert into ShowInfo(ConfigName,AreaName,BeginTime,EndTime,ByOrder,ScreenId) values('{showInfo.ConfigName}','{showInfo.AreaName}','{showInfo.BeginTime}','{showInfo.EndTime}','{showInfo.ByOrder}','{showInfo.ScreenId}')
END
ELSE
BEGIN

Update ShowInfo set ConfigName = '{showInfo.ConfigName}',AreaName = '{showInfo.AreaName}',BeginTime = '{showInfo.BeginTime}',EndTime = '{showInfo.EndTime}',ByOrder= '{showInfo.ByOrder}',ScreenId = '{showInfo.ScreenId}'  where Id = '{showInfo.ID}'
END
";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 变更状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateShowState(string id,int state)
        {
            string sSql = $@"
  Update ShowInfo  set state = {state}  where Id = '{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

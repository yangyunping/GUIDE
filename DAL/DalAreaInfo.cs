using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DalAreaInfo
    {
        Server server = new Server();
        /// <summary>
        /// 获取区域信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetAreaInfo(string key)
        {
            string sSql = $@"Select ROW_NUMBER() OVER(ORDER BY AreaName) RowNum ,* from  AreaInfo  where  1=1 ";
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
        public bool DeleteArea(string areaID)
        {
            string sSql = $@"Delete from AreaInfo where AreaName = '{areaID}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 修改添加区域编号
        /// </summary>
        /// <param name="showInfo"></param>
        /// <returns></returns>
        public bool InsertOrModifyArea(AreaInfo areaInfo)
        {
            string sSql = $@"
IF NOT EXISTS(Select * from AreaInfo where AreaName = '{areaInfo.AreaName}')
BEGIN
Insert into AreaInfo(AreaName) values('{areaInfo.AreaName}')
END
ELSE
BEGIN
Update AreaInfo set AreaName = '{areaInfo.AreaName}' where AreaName = '{areaInfo.AreaName}'
END";
            return server.ExecuteNonQuery(sSql) > 0;
        }
    }
}

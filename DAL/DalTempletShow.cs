using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 模板显示
    /// </summary>
    public class DalTempletShow
    {
        Server server = new Server();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="templetShow"></param>
        /// <returns></returns>
        public bool InsertTempletShow(TempletShow templetShow)
        {
            string sSql = $@"Insert into TempletShow(ShowContent) 
values('{templetShow.ShowContent}')";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteTempletShow(int id)
        {
            string sSql = $@"Delete from TempletShow where ID='{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="templetShow"></param>
        /// <returns></returns>
        public bool ModifyTempletShow(TempletShow templetShow)
        {
            string sSql = $@"Update TempletShow set ShowContent='{templetShow.ShowContent}' where ID='{templetShow.ID}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetTempletShows(string key)
        {
            string sSql = $@"select * from TempletShow where 1=1 {key}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
    }
}

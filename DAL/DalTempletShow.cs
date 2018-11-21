using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalTempletShow
    {
        Server server = new Server();
        public bool InsertTempletShow(TempletShow templetShow)
        {
            string sSql = $@"Insert into TempletShow(FontName,FontSize,FontColor,ShowStyle,ShowContent) 
values('{templetShow.FontName}','{templetShow.FontSize}','{templetShow.FontColor}','{templetShow.ShowStyle}','{templetShow.ShowContent}')";
            return server.ExecuteNonQuery(sSql) > 0;
          
        }
        public bool DeleteTempletShow(int id)
        {
            string sSql = $@"Delete from TempletShow where ID='{id}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        public bool ModifyTempletShow(TempletShow templetShow)
        {
            string sSql = $@"Update TempletShow set FontName='{templetShow.FontName}',FontSize='{templetShow.FontSize}',FontColor='{templetShow.FontColor}',
ShowStyle='{templetShow.ShowStyle}',ShowContent='{templetShow.ShowContent}' where ID='{templetShow.ID}'";
            return server.ExecuteNonQuery(sSql) > 0;
        }
        public DataTable GetTempletShows(string key)
        {
            string sSql = $@"select * from TempletShow where 1=1 {key}";
            return server.ExecuteQuery(sSql).Tables[0];
        }
    }
}

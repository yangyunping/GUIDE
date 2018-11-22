using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public class BllTempletShow
    {
        DalTempletShow dalTempletShow = new DalTempletShow();
        public bool InsertTempletShow(TempletShow templetShow)
        {
            return dalTempletShow.InsertTempletShow(templetShow);
        }
        public bool DeleteTempletShow(int id)
        {
            return dalTempletShow.DeleteTempletShow(id);
        }
        public bool ModifyTempletShow(TempletShow templetShow)
        {
            return dalTempletShow.ModifyTempletShow(templetShow);
        }
        public DataTable GetTempletShows(string key)
        {
            string sKey = string.Empty;
            if (!string.IsNullOrEmpty(key))
            {
                sKey = $@"  and  Content like '%{key}%'";
            }
            return dalTempletShow.GetTempletShows(sKey);
        }
    }
}

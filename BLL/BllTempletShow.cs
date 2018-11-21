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
            return dalTempletShow.GetTempletShows(key);
        }
    }
}

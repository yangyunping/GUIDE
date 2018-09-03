using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public  class BllShowInfo
    {
        DalShowInfo dalShowInfo = new DalShowInfo();
        public DataTable GetShowInfo(string key)
        {
            return dalShowInfo.GetShowInfo(key);
        }

        public  bool DeleteShow(string id)
        {
            return dalShowInfo.DeleteShow(id);
        }

        public  bool InsertOrModifyShow(ShowInfo showInfo)
        {
            return dalShowInfo.InsertOrModifyShow(showInfo);
        }
    }
}

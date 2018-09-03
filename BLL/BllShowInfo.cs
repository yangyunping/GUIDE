using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public  class BllShowInfo
    {
        DalShowInfo dalShowInfo = new DalShowInfo();
        public DataTable GetShowInfo(string areaName)
        {
            return dalShowInfo.GetShowInfo($"  and AreaName like '%{areaName}%'");
        }
        public DataTable GetShowStateInfo(int state)
        {
            return dalShowInfo.GetShowInfo($"  and  State = {state} ");
        }
        public  bool DeleteShow(string id)
        {
            return dalShowInfo.DeleteShow(id);
        }

        public  bool InsertOrModifyShow(ShowInfo showInfo)
        {
            return dalShowInfo.InsertOrModifyShow(showInfo);
        }

        public bool UpdateShowState(string id)
        {
            return dalShowInfo.UpdateShowState(id);
        }
    }
}

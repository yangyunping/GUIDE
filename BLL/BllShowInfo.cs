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
        public DataTable GetShowStateInfo(int state,string order)
        {
            string byOrder = string.Empty;
            switch (order)
            {
                case "开始时间":
                    byOrder = "  order by BeginTime desc";
                    break;
                case "结束时间":
                    byOrder = "  order by EndTime desc";
                    break;
                case "配置编号":
                    byOrder = "  order by ConfigName desc";
                    break;
            }
            return dalShowInfo.GetShowInfo($"  and  State = {state}  {byOrder}");
        }
        public  bool DeleteShow(string id)
        {
            return dalShowInfo.DeleteShow(id);
        }

        public  bool InsertOrModifyShow(ShowInfo showInfo)
        {
            return dalShowInfo.InsertOrModifyShow(showInfo);
        }

        public bool UpdateShowState(string id,int state)
        {
            return dalShowInfo.UpdateShowState(id, state);
        }
    }
}

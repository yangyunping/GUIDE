using DAL;
using MODEL;
using System.Data;

namespace BLL
{
    public class BllAreaInfo
    {
        DalAreaInfo DalAreaInfo = new DalAreaInfo();
        public DataTable GetAreaInfo(string key)
        {
            return DalAreaInfo.GetAreaInfo(key);
        }
        public bool DeleteArea(string areaID)
        {
            return DalAreaInfo.DeleteArea(areaID);
        }
        public bool InsertOrModifyArea(AreaInfo areaInfo)
        {
            return DalAreaInfo.InsertOrModifyArea(areaInfo);
        }
    }
}

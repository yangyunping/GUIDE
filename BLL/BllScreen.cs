using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllScreen
    {
        DalScreen dalScreen = new DalScreen();
        public DataTable GetAreaInfo(string key)
        {
            return dalScreen.GetScreenInfo(key);
        }
        public bool DeleteArea(string areaID)
        {
            return dalScreen.DeleteScreen(areaID);
        }
        public bool InsertOrModifyArea(Screen screen)
        {
            return dalScreen.InsertOrModifyScreen(screen);
        }
    }
}

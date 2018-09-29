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
        public DataTable GetScreenInfo(string key)
        {
            return dalScreen.GetScreenInfo(key);
        }
        public bool DeleteScreen(string ID)
        {
            return dalScreen.DeleteScreen(ID);
        }
        public bool InsertOrModifyScreen(Screens screen)
        {
            return dalScreen.InsertOrModifyScreen(screen);
        }
    }
}

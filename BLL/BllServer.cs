using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class BllServer
    {
        Server Server = new Server();
        public bool TestConnection()
        {
            return Server.TestConnection();
        }

    }
}

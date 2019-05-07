using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ISBiblioteka
{
    public class SqlDataAccess
    {
        public static string LoadConnectionString(string id = "Default")
        {
            //Vraca ime konekcija iz app.config
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

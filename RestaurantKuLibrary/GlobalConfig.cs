using RestaurantKuLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantKuLibrary.Models;
using System.Configuration;

namespace RestaurantKuLibrary
{
    public static class GlobalConfig
    {
        public static RKDataConnection Connection { get; private set; }
        public static void IConnection(DatabaseType db)
        {
            
            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db==DatabaseType.Textfile)
            {
                TextConnector text = new TextConnector();
                Connection = text;

            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
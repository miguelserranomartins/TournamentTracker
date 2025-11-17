using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public static IDataConnection Connection { get; private set; } 


        public static void InitializeConnections(DataBaseType db)
        {
  
           
            if (db == DataBaseType.Sql)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
               Connection = sql;
            }
            else if (db == DataBaseType.TextFile)
            {
                // TODO - Create the text connection
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

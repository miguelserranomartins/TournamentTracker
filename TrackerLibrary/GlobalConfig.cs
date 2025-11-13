using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFile)
        {
            Connections = new List<IDataConnection>();
            if (database)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
               Connections.Add(sql);
            }
            if (textFile)
            {
                // TODO - Create the text connection
                TextConnection text = new TextConnection();
                Connections.Add(text); 
            }
        }

    }
}

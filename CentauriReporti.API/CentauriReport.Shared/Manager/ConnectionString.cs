using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentauriReport.Shared.Manager
{
    public class ConnectionString
    {
        private static ConnectionString _instance;
        private static object _lockThis = new object();

        private ConnectionString() { }

        public static ConnectionString GetState()
        {
            lock (_lockThis)
            {
                if (_instance == null) _instance = new ConnectionString();
            }

            return _instance;
        }

        public string CentauriConnection { get; set; }
        public string CentauriBillingConnection { get; set; }
        public string CentauriRaterConnection { get; set; }
    }
}

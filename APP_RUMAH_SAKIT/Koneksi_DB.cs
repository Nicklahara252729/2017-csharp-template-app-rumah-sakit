using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_RUMAH_SAKIT
{
    class Koneksi_DB
    {
        public static string ConnString = string.Format
            ("Data Source=XE; User Id=dbrs; Password=dbrs;");
        public static OracleConnection GetOracleConnection()
        {
            return new OracleConnection(ConnString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_RUMAH_SAKIT
{
    class connecting
    {
        public static string konek = string.Format("User ID=dbrs;Password=dbrs;Data Source='XE'");
        public static OracleConnection getkonek(){
            return new OracleConnection(konek);
        }
    }
}

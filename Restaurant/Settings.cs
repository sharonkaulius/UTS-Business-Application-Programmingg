using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Settings
    {
        public const string SERVER = "DESKTOP-5MD9Q6I\\SQL2019EXPRESS";
        public const string TABLE_MENU = "restaurant_menu";
        public const string TABLE_TRANSACTION = "restaurant_transaction";
        public const string TABLE_ORDER = "restaurant_order";
        public static string MASTER_CONNECTION_STRING = "Server=" + SERVER + ";Integrated security=SSPI;database=master";
        public static string DB_DATA_CONNECTION_STRING = "Server=" + SERVER + ";Integrated security=SSPI;database=DB_DATA";
    }
}

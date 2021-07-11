using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enchanter_Fashion.DBConnection
{
    class DBConection
    {
        
        public static MySqlConnection getconnection()
        {
            MySqlConnection con;
            String host = "datasource=localhost;port=3306;database=enchanterfashion;username=root;password=";
            con = new MySqlConnection(host);          
            return con;
        }

        public static implicit operator MySqlConnection(DBConection v)
        {
            throw new NotImplementedException();
        }
    }
}

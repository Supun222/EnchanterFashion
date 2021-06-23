using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enchanter_Fashion.Display_Board
{
    class Dbquryset
    {
        string sql_query;

        public String get_query(String catogery)
        {
            if (catogery == "men")
            {
                sql_query = "SELECT  pic_file_name, bkgrnd_file_name FROM display WHERE item_type='men'";
            }
            else if (catogery == "women")
            {
                sql_query= "SELECT pic_file_name, bkgrnd_file_name FROM display WHERE item_type='women'";
            }
            else if (catogery == "kids")
            {
                sql_query = "SELECT  pic_file_name, bkgrnd_file_name FROM display WHERE item_type='kids'";
            }
            else if (catogery == "shoes")
            {
                sql_query = "SELECT  pic_file_name, bkgrnd_file_name FROM display WHERE item_type='shoes'";
            }
            else
            {
                sql_query = "SELECT  pic_file_name, bkgrnd_file_name FROM display";
            }
          
            return sql_query;
        }
    }
}

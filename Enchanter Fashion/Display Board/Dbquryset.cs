using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enchanter_Fashion.Display_Board
{
    class Dbquryset
    {
        string sql_query = null;
        string count_query = null;

        public string get_query(String catogery)
        {
            if (catogery == "men")
            {
                sql_query = "SELECT contain_items.item_name , contain_items.brand , contain_items.price, contain_items.Collection ,display.pic_file_name, display.description FROM contain_items INNER JOIN display ON display.item_name=contain_items.item_name WHERE contain_items.item_type = 'men'";             
            }
            else if (catogery == "women")
            {
                sql_query= "SELECT contain_items.item_name , contain_items.brand , contain_items.price, contain_items.Collection ,display.pic_file_name, display.description FROM contain_items INNER JOIN display ON display.item_name=contain_items.item_name WHERE contain_items.item_type = 'women'";               
            }
            else if (catogery == "kids")
            {
                sql_query = "SELECT contain_items.item_name , contain_items.brand , contain_items.price, contain_items.Collection ,display.pic_file_name, display.description FROM contain_items INNER JOIN display ON display.item_name=contain_items.item_name WHERE contain_items.item_type = 'kids'";               
            }
            else if (catogery == "shoes")
            {
                sql_query = "SELECT contain_items.item_name , contain_items.brand , contain_items.price, contain_items.Collection ,display.pic_file_name, display.description FROM contain_items INNER JOIN display ON display.item_name=contain_items.item_name WHERE contain_items.item_type = 'shoes'";               
            }
            else
            {
                sql_query = "SELECT contain_items.item_name , contain_items.brand , contain_items.price, contain_items.Collection ,display.pic_file_name, display.description FROM contain_items INNER JOIN display ON display.item_name=contain_items.item_name";              
            }
            return sql_query;
        }
    }
}

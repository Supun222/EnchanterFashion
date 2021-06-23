using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Enchanter_Fashion.Display_Board
{
    class Dbquryvalueget
    {
        public MySqlConnection con;
        public ArrayList arrayvalues = new ArrayList();

        
        public string picfilename, backfilename;
        public int size;
        

        public void getconnection()
        {
            String host = "datasource=localhost;port=3306;database=enchanterfashion;username=root;password=";
            con = new MySqlConnection(host);
        }

        public void returnvalues(string sql_qury, int counter)
        {
            getconnection();
            MySqlCommand mycomnd = new MySqlCommand(sql_qury, con);          
            try
            {
                con.Open();
                MySqlDataReader dr = mycomnd.ExecuteReader();
                while (dr.Read())
                {
                    arrayvalues.Add(dr.GetString("pic_file_name").ToString());
                    arrayvalues.Add(dr.GetString("bkgrnd_file_name").ToString());                
                }
            }
            catch(MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            picfilename = arrayvalues[counter].ToString();
            backfilename = arrayvalues[counter + 1].ToString();
            arrayvalues.Clear();

           
            
            con.Close();
        }
    }
}

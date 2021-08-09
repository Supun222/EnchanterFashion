using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enchanter_Fashion.DBConnection;
using MySql.Data.MySqlClient;

namespace Enchanter_Fashion.inventory.UserControls
{
    public partial class uc_home : UserControl
    {
        public uc_home()
        {
            InitializeComponent();
            supcount();
            purcount();
            invoicecount();
            salescount();
        }

        public void supcount() {

           // MySqlConnection conn = DBConection.getconnection();
            //conn.Open();
           // MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText="SELECT count"

            try
            {
                // SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\documents\visual studio 2010\Projects\Inventory Managment System in csharp\Inventory Managment System in csharp\IMS.mdf;Integrated Security=True;User Instance=True");
                MySqlConnection conn = DBConection.getconnection();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(sup_id) From suppliers";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                bunifuLabel7.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }



        public void purcount() {


            try
            {
                
                MySqlConnection conn = DBConection.getconnection();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(bill_no) From sales";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                bunifuLabel3.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }



        public void invoicecount()
        {


            try
            {

                MySqlConnection conn = DBConection.getconnection();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(bill_no) From inventory";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                bunifuLabel5.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }


        public void salescount()
        {


            try
            {

                MySqlConnection conn = DBConection.getconnection();
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT SUM(unit_price*quantity) AS Tot FROM sales";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                bunifuLabel2.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }



    }
}

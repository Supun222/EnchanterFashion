using MySql.Data.MySqlClient;
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
using System.Data.SqlClient;

namespace Enchanter_Fashion.inventory.UserControls
{
    public partial class uc_categories : UserControl
    {


        MySqlConnection conn = DBConection.getconnection();
       

        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        public uc_categories()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            try
            {

                conn.Open();

                String str = "Select * From contain_items";

                MySqlCommand cmd = new MySqlCommand(str, conn);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

               MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;

                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();

                String str = "Select item_id,item_name,item_type,itm_quantity,color,size,brand,price,season,stock_id From contain_items Where item_id = '" + txt_id.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, conn);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;





                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_id.Text = dr.GetValue(0).ToString();
                    txt_name.Text = dr.GetValue(1).ToString();
                    txt_type.Text = dr.GetValue(2).ToString();
                    txt_qty.Text = dr.GetValue(3).ToString();

                    txt_color.Text = dr.GetValue(4).ToString();
                    txt_size.Text = dr.GetValue(5).ToString();
                    txt_brand.Text = dr.GetValue(6).ToString();
                    txt_price.Text = dr.GetValue(7).ToString();
                    txt_season.Text = dr.GetValue(8).ToString();

                }

                conn.Close();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();

                String str = "Select item_id,item_name,item_type,itm_quantity,color,size,brand,price,season,stock_id From contain_items Where item_name = '" + txt_name.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, conn);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;





                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_id.Text = dr.GetValue(0).ToString();
                    txt_name.Text = dr.GetValue(1).ToString();
                    txt_type.Text = dr.GetValue(2).ToString();
                    txt_qty.Text = dr.GetValue(3).ToString();

                    txt_color.Text = dr.GetValue(4).ToString();
                    txt_size.Text = dr.GetValue(5).ToString();
                    txt_brand.Text = dr.GetValue(6).ToString();
                    txt_price.Text = dr.GetValue(7).ToString();
                    txt_season.Text = dr.GetValue(8).ToString();

                }

                conn.Close();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_type.Text = "";
            txt_qty.Text = "";

            txt_color.Text = "";
            txt_size.Text = "";
            txt_brand.Text = "";
            txt_price.Text = "";
            txt_season.Text = "";

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            //===================      error    ============================== 


          /*  try
            {
                if (txt_id.Text == "" || txt_name.Text == "" || txt_type.Text == "" || txt_qty.Text == "" || txt_color.Text == " " || txt_size.Text == "" || txt_brand.Text == "" || txt_price.Text == "" || txt_season.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                   // SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\documents\visual studio 2010\Projects\Inventory Managment System in csharp\Inventory Managment System in csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    conn.Open();

                    String str = "Insert Into contain_items(item_id,item_name,item_type,itm_quantity,color,size,brand,price,season,stock_id) Values ('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_type.Text + "','" + txt_qty.Text + "','"+txt_color.Text+ "','"+ txt_size.Text + "','" + txt_brand.Text + "','" + txt_price.Text + "','"+txt_season+"'')";

                    MySqlCommand cmd = new MySqlCommand(str, conn);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(item_id) From contain_items";

                    MySqlCommand cmd2 = new MySqlCommand(str2, conn);

                    MySqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        //showdata();

                        MessageBox.Show("Customers Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                      //  auto();

                        conn.Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }*/





            //==========================     error    ==========================
        }
    }
}

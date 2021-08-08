using Enchanter_Fashion.DBConnection;
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

namespace Enchanter_Fashion.inventory.UserControls
{
    public partial class uc_items : UserControl
    {

        MySqlConnection conn = DBConection.getconnection();



        public uc_items()
        {
            InitializeComponent();
            LoadUser();
        }


        public void LoadUser()
        {
            try
            {

                conn.Open();

                String str = "Select * From sales";

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

                String str = "Select bill_no,item_id,item_name,unit_price,quantity From sales Where bill_no = '" + txt_bill.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, conn);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;



                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_bill.Text = dr.GetValue(0).ToString();
                    txt_item.Text = dr.GetValue(1).ToString();
                    txt_name.Text = dr.GetValue(2).ToString();
                    txt_price.Text = dr.GetValue(3).ToString();

                    txt_qty.Text = dr.GetValue(4).ToString();

                   
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

                String str = "Select bill_no,item_id,item_name,unit_price,quantity From sales Where bill_no = '" + txt_item.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, conn);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;



                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txt_bill.Text = dr.GetValue(0).ToString();
                    txt_item.Text = dr.GetValue(1).ToString();
                    txt_name.Text = dr.GetValue(2).ToString();
                    txt_price.Text = dr.GetValue(3).ToString();

                    txt_qty.Text = dr.GetValue(4).ToString();


                }

                conn.Close();


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (txt_bill.Text == "" || txt_item.Text == "" || txt_name.Text == "" || txt_price.Text == "" || txt_qty.Text=="")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //MySqlConnection con = new MySqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\documents\visual studio 2010\Projects\Inventory Managment System in csharp\Inventory Managment System in csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    conn.Open();

                    String str = "Insert Into sales (bill_no,item_id,item_name,unit_price,quantity) Values ('" + txt_bill.Text + "','" + txt_item.Text + "','" + txt_name.Text + "','" + txt_price.Text + "','" + txt_qty.Text + "')";

                    MySqlCommand cmd = new MySqlCommand(str, conn);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(bill_no) From sales";

                    MySqlCommand cmd2 = new MySqlCommand(str2, conn);

                    MySqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        //LoadUser();

                        MessageBox.Show("Customers Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                       // auto();

                        conn.Close();

                    }
                    LoadUser();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }


        private void clear()
        {
            txt_bill.Text = "";
            txt_item.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";

            txt_qty.Text = "";

            

        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                if (txt_bill.Text == "" || txt_item.Text == "" || txt_name.Text == "" || txt_price.Text == "" || txt_qty.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\documents\visual studio 2010\Projects\Inventory Managment System in csharp\Inventory Managment System in csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    conn.Open();

                    String str = "Update sales Set item_id = '" + txt_item.Text + "',item_name = '" + txt_name.Text + "',unit_price = '" + txt_price.Text + "',quantity = '" + txt_qty.Text + "' Where bill_no = '" + txt_bill.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, conn);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(bill_no) From sales";

                    MySqlCommand cmd2 = new MySqlCommand(str2, conn);

                    MySqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        //LoadUser();

                        MessageBox.Show("Customers Updated Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        //  auto();

                        conn.Close();

                    }
                    LoadUser();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }










        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {


           




        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_bill.Text == "" || txt_item.Text == "" || txt_name.Text == "" || txt_price.Text == "" || txt_qty.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                  //  MySqlConnection conn = new MySqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\hp\documents\visual studio 2010\Projects\Inventory Managment System in csharp\Inventory Managment System in csharp\IMS.mdf;Integrated Security=True;User Instance=True");

                    conn.Open();

                    String str = "Delete From sales Where bill_no = '" + txt_bill.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, conn);

                    cmd.ExecuteNonQuery();

                   // LoadUser();

                    MessageBox.Show("User Delete Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();

                  //  auto();

                    conn.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadUser();



        }
    }
}

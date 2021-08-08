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

                String str = "Select item_id,item_name,item_type,itm_quantity,color,size,brand,price,season,stock_id From contain_items Where item_id = '" + supplierIdTb.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, conn);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;





                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    supplierIdTb.Text = dr.GetValue(0).ToString();
                    companyNameTb.Text = dr.GetValue(1).ToString();
                    addressTb.Text = dr.GetValue(2).ToString();
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

                String str = "Select item_id,item_name,item_type,itm_quantity,color,size,brand,price,season,stock_id From contain_items Where item_name = '" + companyNameTb.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, conn);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgvUser.DataSource = dt;





                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    supplierIdTb.Text = dr.GetValue(0).ToString();
                    companyNameTb.Text = dr.GetValue(1).ToString();
                    addressTb.Text = dr.GetValue(2).ToString();
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
            supplierIdTb.Text = "";
            companyNameTb.Text = "";
            addressTb.Text = "";
            txt_qty.Text = "";

            txt_color.Text = "";
            txt_size.Text = "";
            txt_brand.Text = "";
            txt_price.Text = "";
            txt_season.Text = "";

        }
    }
}

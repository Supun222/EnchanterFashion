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
    public partial class uc_invoices : UserControl
    {
        public uc_invoices()
        {
            InitializeComponent();
            display(null, null);
            //bunifuButton6.TextAlign = ContentAlignment.TopCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (supplierIdTb.Text == "")
            {
                MessageBox.Show("Please enter the supplier id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (itemIdTb.Text == "")
            {
                MessageBox.Show("Please enter the item id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameTb.Text == "")
            {
                MessageBox.Show("Please enter the item name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantityTb.Text == "")
            {
                MessageBox.Show("Please enter the quantity", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (priceTb.Text == "")
            {
                MessageBox.Show("Please enter the unit price", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dbSetInvoice save = new dbSetInvoice();
                save.insertData(billNoTb.Text,Convert.ToInt32(itemIdTb.Text), supplierIdTb.Text, nameTb.Text, Convert.ToInt32(quantityTb.Text), float.Parse(priceTb.Text));
            }
            display(null, null);
            billNoTb.Text = "";
            itemIdTb.Text = "";
            nameTb.Text = "";
            supplierIdTb.Text = "";
            quantityTb.Text = "";
            priceTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (billNoTb.Text == "")
            {
                MessageBox.Show("Please enter the bill no", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (supplierIdTb.Text == "")
            {
                MessageBox.Show("Please enter the supplier id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (itemIdTb.Text == "")
            {
                MessageBox.Show("Please enter the item id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameTb.Text == "")
            {
                MessageBox.Show("Please enter the item name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantityTb.Text == "")
            {
                MessageBox.Show("Please enter the quantity", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (priceTb.Text == "")
            {
                MessageBox.Show("Please enter the unit price", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dbSetInvoice edit = new dbSetInvoice();
                if (edit.checkItem(billNoTb.Text) == true)
                {
                    edit.editData(billNoTb.Text, Convert.ToInt32(itemIdTb.Text), supplierIdTb.Text, nameTb.Text, Convert.ToInt32(quantityTb.Text), float.Parse(priceTb.Text));
                }
                else
                {
                    MessageBox.Show("Please enter correct bill no", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            display(null, null);
            billNoTb.Text = "";
            itemIdTb.Text = "";
            nameTb.Text = "";
            supplierIdTb.Text = "";
            quantityTb.Text = "";
            priceTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (billNoTb.Text == "")
                {
                    MessageBox.Show("Please enter the bill no.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dbSetInvoice delete = new dbSetInvoice();
                    if (delete.checkItem(billNoTb.Text) == true)
                    {
                        if(MessageBox.Show("Are you sure?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                        {
                            delete.deleteData(billNoTb.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct bill number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            display(null, null);
            billNoTb.Text = "";
            itemIdTb.Text = "";
            nameTb.Text = "";
            supplierIdTb.Text = "";
            quantityTb.Text = "";
            priceTb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT * FROM inventory WHERE bill_no LIKE '%" + billNoTb.Text + "%'";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter myadpter = new MySqlDataAdapter();
                myadpter.SelectCommand = mycmd;
                DataTable dTable = new DataTable();
                myadpter.Fill(dTable);
                bunifuDataGridView1.DataSource = dTable;
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            billNoTb.Text = "";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT * FROM inventory WHERE item_id LIKE '%" + itemIdTb.Text + "%'";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter myadpter = new MySqlDataAdapter();
                myadpter.SelectCommand = mycmd;
                DataTable dTable = new DataTable();
                myadpter.Fill(dTable);
                bunifuDataGridView1.DataSource = dTable;
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            itemIdTb.Text = "";
        }

        private void display(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConection.getconnection();
                string query = "SELECT* FROM inventory";
                Console.WriteLine(query);
                MySqlCommand mycmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataAdapter myadpter = new MySqlDataAdapter();
                myadpter.SelectCommand = mycmd;
                DataTable dTable = new DataTable();
                myadpter.Fill(dTable);
                bunifuDataGridView1.DataSource = dTable;
                con.Close();
            }
            catch (MySqlException exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}

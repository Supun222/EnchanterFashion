using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enchanter_Fashion.inventory.UserControls;
using Enchanter_Fashion.Signup_and_Registration;

namespace Enchanter_Fashion.inventory
{
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();

            /* uc_home1.BringToFront();

             uc_orders.SendToBack();
             uc_items1.SendToBack();
             uc_users1.SendToBack();
             uc_invoices1.SendToBack();
             uc_categories1.SendToBack();*/

            uc_home uch = new uc_home();
            AddControlsToPanel(uch);

        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //
            /* uc_home1.BringToFront();

             uc_orders.SendToBack();
             uc_items1.SendToBack();
             uc_users1.SendToBack();
             uc_invoices1.SendToBack();
             uc_categories1.SendToBack();*/

            uc_home uch = new uc_home();
            AddControlsToPanel(uch);
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            /* uc_home1.SendToBack();

             uc_orders.SendToBack();
             //
             uc_items1.BringToFront();
             uc_users1.SendToBack();
             uc_invoices1.SendToBack();
             uc_categories1.SendToBack();*/

            uc_items uch = new uc_items();
            AddControlsToPanel(uch);

        }

        private void btncat_Click(object sender, EventArgs e)
        {
            //uc_home1.SendToBack();

            /*  uc_orders.SendToBack();
              uc_items1.SendToBack();
              uc_users1.SendToBack();
              uc_invoices1.SendToBack();
              //
              uc_categories2.BringToFront();*/


            uc_categories uch = new uc_categories();
            AddControlsToPanel(uch);

        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            /* uc_home1.SendToBack();

             uc_orders.SendToBack();
             uc_items1.SendToBack();
             //
             uc_users1.BringToFront();
             uc_invoices1.SendToBack();
             uc_categories1.SendToBack();*/

            uc_users uch = new uc_users();
            AddControlsToPanel(uch);


        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            /*  uc_home1.SendToBack();
              //
              uc_orders.BringToFront();
              uc_items1.SendToBack();
              uc_users1.SendToBack();
              uc_invoices1.SendToBack();
              uc_categories1.SendToBack();*/

            uc_suppliers uch = new uc_suppliers();
            AddControlsToPanel(uch);

        }

        private void btninvo_Click(object sender, EventArgs e)
        {
            /* uc_home1.SendToBack();

             uc_orders.SendToBack();
             uc_items1.SendToBack();
             uc_users1.SendToBack();
             //
             uc_invoices2.BringToFront();
             uc_categories1.SendToBack();*/

            uc_invoices uch = new uc_invoices();
            AddControlsToPanel(uch);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Application.Exit();


            DialogResult dirRes = MessageBox.Show("Do you want to Exit ?", "Enchanter Fashion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Check the Responce
            if (dirRes == DialogResult.Yes)
            {

                this.Close();
                Form1 nf = new Form1();
                nf.ShowDialog();
                //Form1.open
            
            }


            }
    }
}

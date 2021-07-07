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

namespace Enchanter_Fashion.inventory
{
    public partial class form_dashboard : Form
    {
        public form_dashboard()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 400);
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;




            uc_home uch = new uc_home();
            AddControlsToPanel(uch);


        }


        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }



        private void btnhome_Click(object sender, EventArgs e)
        {
            uc_home uch = new uc_home();
            AddControlsToPanel(uch);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            uc_categories uch = new uc_categories();
            AddControlsToPanel(uch);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            uc_items uch = new uc_items();
            AddControlsToPanel(uch);
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            uc_suppliers uch = new uc_suppliers();
            AddControlsToPanel(uch);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            uc_invoices uch = new uc_invoices();
            AddControlsToPanel(uch);
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            uc_users uch = new uc_users();
            AddControlsToPanel(uch);
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            uc_orders uch = new uc_orders();
            AddControlsToPanel(uch);
        }

        private void panelControls_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class uc_invoices : UserControl
    {
        public uc_invoices()
        {
            InitializeComponent();
            //bunifuButton6.TextAlign = ContentAlignment.TopCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (billNoTb.Text == "")
            {
                MessageBox.Show("Please enter the bill no",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            }
        }
    }
}

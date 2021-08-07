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
    public partial class uc_suppliers : UserControl
    {
        public uc_suppliers()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(companyNameTb.Text == "")
            {
                MessageBox.Show("Please enter the supplier name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(addressTb.Text == "")
            {
                MessageBox.Show("Please Enter the address");
            }
            else if(telephoneTb.Text == "")
            {
                MessageBox.Show("Please enter the telephone number");
            }
            else
            {
                if(telephoneTb.Text.Length == 10)
                {
                    dbSetSuppliers saveItems = new dbSetSuppliers();
                    saveItems.insertData(companyNameTb.Text, addressTb.Text, telephoneTb.Text);
                }
                else
                {
                    MessageBox.Show("Please enter the correct phone number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*if(companyNameTb.Text != "")
            {
                if(telephoneTb.Text.Length == 10)
                {
                    dbSetSuppliers saveItems = new dbSetSuppliers();
                    saveItems.insertData(companyNameTb.Text, addressTb.Text, telephoneTb.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a correct phone number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the supplier name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
           

            supplierIdTb.Text = "";
            companyNameTb.Text = "";
            addressTb.Text = "";
            telephoneTb.Text = "";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (supplierIdTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier id", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(companyNameTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addressTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier adderess", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(telephoneTb.Text == "")
            {
                MessageBox.Show("Please Enter the suplier telephone number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(telephoneTb.Text.Length == 10)
                {
                    dbSetSuppliers edit = new dbSetSuppliers();
                    if (edit.checkItem(supplierIdTb.Text) == true)
                    {
                        edit.editData(supplierIdTb.Text, companyNameTb.Text, addressTb.Text, telephoneTb.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the correct supplier id.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            /*if (companyNameTb.Text != "")
            {
                if (telephoneTb.Text.Length == 10)
                {
                    dbSetSuppliers editItems = new dbSetSuppliers();
                    editItems.editData(supplierIdTb.Text, companyNameTb.Text, addressTb.Text, telephoneTb.Text);
                }
                else
                {
                    MessageBox.Show("Please enter a correct phone number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the supplier name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


            supplierIdTb.Text = "";
            companyNameTb.Text = "";
            addressTb.Text = "";
            telephoneTb.Text = "";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (supplierIdTb.Text == "")
            {
                MessageBox.Show("Enter NIC number", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                dbSetSuppliers remove = new dbSetSuppliers();
                if (remove.checkItem(supplierIdTb.Text) == true)
                {
                    remove.deleteData(supplierIdTb.Text, companyNameTb.Text, addressTb.Text, telephoneTb.Text);
                }
                else
                {
                    MessageBox.Show("Please enter correct supplier id.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            supplierIdTb.Text = "";
            companyNameTb.Text = "";
            addressTb.Text = "";
            telephoneTb.Text = "";
        }
    }
}

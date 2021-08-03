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
            dbSetSuppliers saveItems = new dbSetSuppliers();
            saveItems.insertData(companyNameTb.Text, addressTb.Text, telephoneTb.Text);
        }
    }
}

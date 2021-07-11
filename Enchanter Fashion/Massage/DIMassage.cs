using Enchanter_Fashion.inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enchanter_Fashion.Massage
{
    public partial class DIMassage : Form
    {
        public DIMassage()
        {
            InitializeComponent();
            displayandInventorymsg1.bunifuButton1.Click += loginmenubtn_click;
            displayandInventorymsg1.bunifuButton2.Click += inventymenubytton_click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void loginmenubtn_click(object sender, EventArgs e)
        {
            displaypanel ds = new displaypanel();
            ds.ShowDialog();
            this.Close();
        }

        private void inventymenubytton_click(object sender, EventArgs e)
        {
            testing invn = new testing();
            invn.ShowDialog();
            this.Close();
        }
    }
}

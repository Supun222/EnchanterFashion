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
            this.Hide();
            displaypanel ds = new displaypanel();
            this.Closed += (s, args) => this.Close();
            ds.Show();
        }

        private void inventymenubytton_click(object sender, EventArgs e)
        {
            this.Hide();
            testing invn = new testing();
            this.Closed += (s, args) => this.Close();
            invn.Show();
        }
    }
}

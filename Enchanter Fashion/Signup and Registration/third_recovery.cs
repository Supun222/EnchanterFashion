using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enchanter_Fashion.Signup_and_Registration
{
    public partial class third_recovery : UserControl
    {
        public third_recovery()
        {
            InitializeComponent();
            new_pswd.Text = "";
            // The password character is an asterisk.
            new_pswd.PasswordChar = '*';

            confirm_pswd.Text = "";
            // The password character is an asterisk.
            confirm_pswd.PasswordChar = '*';
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

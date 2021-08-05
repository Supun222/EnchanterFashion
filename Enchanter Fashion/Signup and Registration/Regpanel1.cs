using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enchanter_Fashion
{
    public partial class Regpanel1 : UserControl
    {
        public Regpanel1()
        {
            InitializeComponent();
            // Set to no text.
            reg1_paswd_txt.Text = "";
            reg1_cmpaswd_txt.Text = "";
            // The password character is an asterisk.
            reg1_paswd_txt.PasswordChar = '*';
            reg1_cmpaswd_txt.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            reg1_paswd_txt.MaxLength = 14;
            reg1_cmpaswd_txt.MaxLength = 14;
        }

        private void reg1nxt_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

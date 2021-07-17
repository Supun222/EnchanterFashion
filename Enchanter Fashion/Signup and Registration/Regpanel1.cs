using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            regpswd.Text = "";
            regcnfrmpswd.Text = "";
            // The password character is an asterisk.
            regpswd.PasswordChar = '*';
            regcnfrmpswd.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            regpswd.MaxLength = 14;
            regcnfrmpswd.MaxLength = 14;
        }

        
    }
}

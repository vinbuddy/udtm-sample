using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component
{
    public partial class NumericTextbox : TextBox
    {
        public NumericTextbox()
        {
            InitializeComponent();

            this.KeyPress += new KeyPressEventHandler(NumericTextbox_KeyPress);
        }

        private void NumericTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ErrorProvider;
using System.Text.RegularExpressions;

namespace Component
{
    public partial class EmailTextbox : TextBox
    {

        private ErrorProvider errorProvider = new ErrorProvider();

        public EmailTextbox()
        {
            InitializeComponent();

            this.KeyPress += new KeyPressEventHandler(EmailTextbox_KeyPress);
        }

        private void EmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isEmail())
            {
                errorProvider.SetError(this, "Invalid email");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private bool isEmail()
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            return reg.Match(reg);
        }
    }
}
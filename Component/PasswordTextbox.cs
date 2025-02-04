﻿using System;
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
    public partial class PasswordTextbox : TextBox
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public PasswordTextbox()
        {
            InitializeComponent();

            this.PasswordChar = '*';

            this.TextChanged += PasswordTextbox_TextChanged;
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length > 12)
            {
                errorProvider.SetError(this, "Mat khau khong duoc qua 12 ki tu");
                return;            
            }

            if (this.Text.Length < 6)
            {
                errorProvider.SetError(this, "Mat khau khong phai it nhat 6 ki tu");
                return;
            }

            errorProvider.Clear();
        }


        

    }
}

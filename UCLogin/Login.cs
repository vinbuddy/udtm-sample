using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library;

namespace UCLogin
{
    public partial class Login : UserControl
    {

        public string _connectionString;

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        SQLClass sql = new SQLClass();



        public Login()
        {
            InitializeComponent();

            this.btn_login.Click += btn_login_Click;
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            // Create connection
            sql.CreateConnection(_connectionString);

            string email = txt_email.Text;
            string password = txt_password.Text;

            if (_connectionString == "" || email == "" || password == "")
            {
                MessageBox.Show("ERROR");
                return;
            }


            string query = "SELECT COUNT(*) FROM Users WHERE Email = '" + email + "'" + "AND Password = '" + password + "'";

            int result = (int)sql.ExecuteScalar(query);

            if (result > 0)
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                MessageBox.Show("Login failed");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhTheVinh_20001210660_Buoi02
{
    public partial class FormTestUCLogin : Form
    {
        public FormTestUCLogin()
        {
            InitializeComponent();

            login1._connectionString = "Data Source=A102PC30\\CSSQL08;Initial Catalog=TestUC;Integrated Security=True";
        }
    }
}

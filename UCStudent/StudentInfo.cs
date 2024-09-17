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


namespace UCStudent
{
    public partial class StudentInfo: UserControl
    {

        

        public StudentInfo()
        {
            InitializeComponent();
        }

        public void renderStudentUI(Student student) {

            if (student == null)
            {
                MessageBox.Show("NULLLLL");
                return;
            }

            label_mssv.Text = "MSSV: " + student.MSSV;
            label_tensv.Text = "Ten SV: " + student.TenSV;
            label_malop.Text = "Ma lop: " + student.MaLop;
            label_ngaysinh.Text = "Ngay sinh: " + student.NgaySinh;
            label_gioitinh.Text = "Gioi tinh: " + student.GioiTinh;
            label_cmnd.Text = "CMND: " + student.CMND;
        }
    }
}

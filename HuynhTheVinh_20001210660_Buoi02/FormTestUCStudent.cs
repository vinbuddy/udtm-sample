using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library;

namespace HuynhTheVinh_20001210660_Buoi02
{
    public partial class FormTestUCStudent : Form
    {
        public FormTestUCStudent()
        {
            InitializeComponent();
            loadStudent();
        }

        public void loadStudent()
        {

            List<Student> students = new Student().DocSinhVienTuFile("E:\\LuuDuLieuSV\\HuynhTheVinh\\HuynhTheVinh_20001210660_Buoi02\\HuynhTheVinh_20001210660_Buoi02\\student.txt");

            studentInfo1.renderStudentUI(students[0]);

            Console.WriteLine(students[0].CMND);

            
        }
    }
}

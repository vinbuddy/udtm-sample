using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student
{
    public string MSSV { get; set; }
    public string TenSV { get; set; }
    public string MaLop { get; set; }
    public DateTime NgaySinh { get; set; }
    public bool GioiTinh { get; set; } // true: Nam, false: Nữ
    public string CMND { get; set; }

    public List<Student> DocSinhVienTuFile(string filePath)
    {
        List<Student> students = new List<Student>();
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in
     lines)
            {
                string[] fields = line.Split(',');
                if (fields.Length
     == 6)
                {
                    Student student = new Student
                    {
                        MSSV = fields[0],
                        TenSV = fields[1],
                        MaLop = fields[2],
                        NgaySinh = DateTime.ParseExact(fields[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        GioiTinh = bool.Parse(fields[4]),
                        CMND = fields[5]
                    };
                    students.Add(student);
                }
            }
        }
        return students;
    }
}
}

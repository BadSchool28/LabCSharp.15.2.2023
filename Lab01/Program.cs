// author: Nguyễn Quang Trường
// class: 20MC

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{

    internal class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student()
        {
            SID = 923;
            TenSV = "QuangTruong";
            Khoa = "KhoaHocMayTinh";
            DiemTB = 8;
        }

        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }

        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }

        public float Mark
        {
            get { return DiemTB; }
            set
            {
                DiemTB = value;
            }
        }
        public void Show()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("MSV: {0} ", this.SID);
            Console.WriteLine("Tên sv: {0} ", this.TenSV);
            Console.WriteLine("Khoa: {0} ", this.Khoa);
            Console.WriteLine("Điểm TB: {0} ", this.DiemTB);
        }

    }

    class Tester
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] DSSV;
            int n;
            Console.WriteLine("Nhập số lượng sinh viên:");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n*********** Nhập danh sách sinh viên ***********");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.WriteLine("***** Nhập thông tin sv thứ {0} *****", i + 1);
                Console.Write("Nhập MSV: ");
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Nhập tên: ");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhập khoa: ");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhập điểm trung bình: ");
                DSSV[i].Mark = float.Parse(Console.ReadLine());


            }
            Console.WriteLine("\n*********** Xuất danh sách sinh viên ***********");
            foreach (Student sv in DSSV)
                sv.Show();
            Console.ReadLine();

        }

    }
}

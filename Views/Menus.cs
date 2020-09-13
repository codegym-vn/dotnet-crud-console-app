using ExamModule2.Entities;
using System;

namespace ExamModule2.Views
{
    class Menus
    {
        public static int MenuSystem()
        {
            Console.WriteLine("1: Hiển thị thông tin tất cả nhân viên");
            Console.WriteLine("2: Thêm mới nhân viên");
            Console.WriteLine("3: Liệt kê danh sách nhân viên fulltime có lương thấp hơn lương trung bình");
            Console.WriteLine("4: Số lương phải trả cho toàn bộ nhân viên bán thời gian");
            Console.WriteLine("5: Sắp xếp nhân viên toàn thời gian theo số lương tăng dần");
            Console.Write("Bạn Chọn:"); 
            return Convert.ToInt32(Console.ReadLine());
        }
        public static NhanVien AddMenuNv()
        {
            NhanVien nv = new NhanVien();
            Console.Write("Mã Nhân Viên: ");
            nv.MaNv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Họ Và Tên: ");
            nv.HoTen = Console.ReadLine();
            Console.Write("Tuổi: ");
            nv.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số Điện Thoại: ");
            nv.Sdt = Convert.ToInt32(Console.ReadLine()).ToString();
            Console.Write("Email: ");
            nv.Email = Console.ReadLine();
            return nv;
        }
        public static NhanVien AddMenuNv(int type)
        {
            if (type == 1)
            {
                NvFullTime nvFullTime = new NvFullTime();
                NhanVien nv = AddMenuNv();
                nvFullTime.MaNv = nv.MaNv;
                nvFullTime.HoTen = nv.HoTen;
                nvFullTime.Age = nv.Age;
                nvFullTime.Sdt = nv.Sdt;
                nvFullTime.Email = nv.Email;
                Console.Write("Tiền Thưởng: ");
                nvFullTime.Bonus = float.Parse(Console.ReadLine());
                Console.Write("Tiền Phạt: ");
                nvFullTime.Fines = float.Parse(Console.ReadLine());
                Console.Write("Lương Cứng: ");
                nvFullTime.FixedSalary = float.Parse(Console.ReadLine());
                nvFullTime.Salary = nvFullTime.GetSalary();
                return nvFullTime;
            }
            else
            {
                NvPartTime nvPartTime = new NvPartTime();
                NhanVien nv = AddMenuNv();
                nvPartTime.MaNv = nv.MaNv;
                nvPartTime.HoTen = nv.HoTen;
                nvPartTime.Age = nv.Age;
                nvPartTime.Sdt = nv.Sdt;
                nvPartTime.Email = nv.Email;
                Console.Write("Giờ Làm: ");
                nvPartTime.Hour = Convert.ToInt32(Console.ReadLine());
                nvPartTime.Salary = nvPartTime.GetSalary();
                return nvPartTime;
            }


        }
    }
}

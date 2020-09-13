using System;
namespace ExamModule2.Entities
{
    class NvPartTime : NhanVien
    {
        public int Hour { get; set; }
        public override double GetSalary()
        {
            double salary = 100000 * Hour;
            return salary;
        }
        public override void Info()
        { 
            Console.WriteLine("--- Mã nhân viên: {0}," +
                                " Họ Và Tên: {1}," +
                                " Tuổi: {2}," +
                                " Số điện thoại {3}," +
                                " Email: {4}," +
                                " Giờ làm việc: {5}," +
                                " Lương thực lĩnh {6}:",
                                MaNv, HoTen, Age, Sdt, Email, Hour, Salary); 
        }
    }
}
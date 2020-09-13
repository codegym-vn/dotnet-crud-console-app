using System;

namespace ExamModule2.Entities
{
    class NvFullTime : NhanVien
    {
        public float Bonus { get; set; }
        public float Fines { get; set; }
        public float FixedSalary { get; set; }
        public override double GetSalary()
        {
            double salary = FixedSalary + (Bonus - Fines);
            return salary;
        }
        public override void Info()
        {
            Console.WriteLine("--- Mã Nhân Viên: {0}," +
                                " Họ Và Tên: {1}," +
                                " Tuổi: {2}," +
                                " Số điện thoại {3}," +
                                " Email: {4}," +
                                " Tiền Thưởng: {5}," +
                                " Tiền Phạt: {6}," +
                                " Lương Cứng: {7}," +
                                " Tổng Lương {8}---",
                                 MaNv, HoTen, Age, Sdt, Email, Bonus, Fines, FixedSalary, Salary);
        }
    }
}

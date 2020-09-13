
namespace ExamModule2.Entities
{
    class NhanVien
    {
        public int MaNv { get; set; }
        public string HoTen { get; set; }
        public int Age { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public virtual double GetSalary()
        {
            return 0.0;
        }
        public virtual void Info()
        {

        }
    }
}

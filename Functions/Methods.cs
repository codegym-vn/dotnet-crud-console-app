
using ExamModule2.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ExamModule2.Functions
{
    class Methods
    {
        static List<NhanVien> listData;
        public Methods()
        {
            listData = new List<NhanVien>();
            if (listData.Count == 0)
            {
                listData = InitData();
            }
        }
        public List<NhanVien> InitData()
        {
            if (listData.Count == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    NvFullTime nvFullTime = new NvFullTime();
                    nvFullTime.MaNv = i;
                    nvFullTime.HoTen = "Name" + i;
                    nvFullTime.Age = i;
                    nvFullTime.Sdt = "Sdt" + i;
                    nvFullTime.Email = "Email" + i;
                    nvFullTime.Bonus = 11111 + i;
                    nvFullTime.Fines = 50 + (i * 2);
                    nvFullTime.FixedSalary = 1000;
                    nvFullTime.Salary = nvFullTime.GetSalary();
                    listData.Add(nvFullTime);
                }
                for (int i = 0; i < 10; i++)
                {
                    NvPartTime nvPartTime = new NvPartTime();
                    nvPartTime.MaNv = i;
                    nvPartTime.HoTen = "Name" + i;
                    nvPartTime.Age = i;
                    nvPartTime.Sdt = "Sdt" + i;
                    nvPartTime.Email = "Email" + i;
                    nvPartTime.Hour = i + 5;
                    nvPartTime.Salary = nvPartTime.GetSalary();
                    listData.Add(nvPartTime);
                }
                #region
                NvFullTime nvFullTime2 = new NvFullTime();
                nvFullTime2.MaNv = 1;
                nvFullTime2.HoTen = "Name" + 1;
                nvFullTime2.Age = 1;
                nvFullTime2.Sdt = "Sdt" + 1;
                nvFullTime2.Email = "Email" + 1;
                nvFullTime2.Bonus = 111 + 1;
                nvFullTime2.Fines = 50 ;
                nvFullTime2.FixedSalary = 1000;
                nvFullTime2.Salary = nvFullTime2.GetSalary();
                listData.Add(nvFullTime2);

                NvPartTime nvPartTime2 = new NvPartTime();
                nvPartTime2.MaNv = 2;
                nvPartTime2.HoTen = "Name" + 2;
                nvPartTime2.Age = 2;
                nvPartTime2.Sdt = "Sdt" + 2;
                nvPartTime2.Email = "Email" + 2;
                nvPartTime2.Hour = 2 + 5;
                nvPartTime2.Salary = nvPartTime2.GetSalary();
                #endregion
            }
            return listData;
        }
        public static void GetAllInfo()
        {
            foreach (var employee in listData)
            {
                employee.Info();
            }
        }

        public static void AddNewEmployee(NhanVien nv)
        {
            listData.Add(nv);
        }

        public static double GetAverageSalary()
        {
            double average = 0;
            int employeeCount = 0;
            foreach (var nv in listData)
            {
                if (typeof(NvFullTime).IsInstanceOfType(nv))
                {
                    average += nv.Salary;
                }
                employeeCount++;
            }
            average = average / employeeCount;
            return average;
        }

        public static List<NhanVien> GetInfoEmployee()
        {
            List<NhanVien> employees = new List<NhanVien>();
            double average = GetAverageSalary();
            foreach (var nv in listData)
            {
                if (nv.Salary < average)
                {
                    employees.Add(nv);
                }
            }
            return employees;
        }

        public static double TotalSalaryForParttime()
        {
            double total = 0;
            foreach (var nv in listData)
            {
                if (typeof(NvPartTime).IsInstanceOfType(nv))
                {
                    total += nv.Salary;
                }
            }
            return total;
        }
        public static void SortBySalary()
        {
            listData = listData.OrderByDescending(employee => employee.Salary).ThenBy(e => e.MaNv).ToList();
            foreach (var item in listData)
            {
                item.Info();
            }
        }
    }
}

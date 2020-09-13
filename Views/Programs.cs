
using System;
using System.Text;
using ExamModule2.Entities;
using ExamModule2.Functions;
using ExamModule2.Views;

namespace ExamModule2.View
{
    class Programs
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Methods m = new Methods(); 
            do
            {
            menu_system:
                int choice = Menus.MenuSystem();
                switch (choice)
                {
                    case 1:
                        Methods.GetAllInfo();
                        break;
                    case 2:
                        do
                        {
                        menu_add_new:
                            NhanVien nhanVien;
                            Console.WriteLine("1: Nhân viên toàn thời gian");
                            Console.WriteLine("2: Nhân viên bán thời gian");
                            Console.WriteLine("0: Thoát");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice != 0)
                            {
                                nhanVien = choice == 1 ? Menus.AddMenuNv(choice) : Menus.AddMenuNv(choice);
                                Methods.AddNewEmployee(nhanVien);
                                Console.WriteLine("Thêm Thành Công");
                                Console.WriteLine("Bạn có muốn tiếp tục: Y/N?");
                                string userChoice = Console.ReadLine();
                                if (userChoice == "Y" || userChoice == "y")
                                {

                                    goto menu_add_new;
                                }
                                else
                                {
                                    goto menu_system;
                                }
                            }
                            else
                            {
                                goto menu_system;
                            }
                        } while (true);
                    case 3:
                        var listData = Methods.GetInfoEmployee();
                        foreach (var item in listData)
                        {
                            item.Info();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tổng số tiền phải trả cho nhân viên bán thời gian: {0}", Methods.TotalSalaryForParttime());
                        break;
                    case 5:
                        Methods.SortBySalary();
                        break;
                }
            } while (true);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp1
{
    class Program
    {

        static void Main(string[] args)
        {
            employee e1;
            IList<employee> ls = new List<employee>();
            int noOfRecords, option;

            Console.WriteLine("How may Records do you want to enter?");
            noOfRecords = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter 1) To add record: \n2) To Search Record: \n3 To Exit");
            option = Convert.ToInt32(Console.ReadLine());


            switch (option) {

                case 1:
                    {
                        int i = 1;
                        while (i <= noOfRecords)
                        {
                            e1 = new employee();
                            Console.WriteLine("Enter Employee No.");
                            e1.employeeNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name.");
                            e1.employeeName = Console.ReadLine();
                            Console.WriteLine("Enter Employee Designation.");
                            e1.desig = Console.ReadLine();
                            Console.WriteLine("Enter Employee Dept No.");
                            e1.deptNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Employee Salary");
                            e1.salary = Convert.ToInt32(Console.ReadLine());
                            ls.Add(e1);
                            Console.WriteLine("Record entered successfully for Empno{0} Name{1}", e1.employeeNo, e1.employeeName);
                            i++;
                        }
                    }
        }

            Console.Read();
        }
    }
}

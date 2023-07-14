using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days for each employee: ");
            int numWorkingDays = int.Parse(Console.ReadLine());

            int[][] salaries = new int[numEmployees][];

            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numWorkingDays];

                Console.WriteLine($"Enter salaries for employee {i + 1}:");
                for (int j = 0; j < numWorkingDays; j++)
                {
                    Console.Write($"Day{j + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nWeekly salary calculation:");
            for (int i = 0; i < numEmployees; i++)
            {
                int totalSalary = 0;

                Console.WriteLine($"Employee {i + 1}:");
                for (int j = 0; j < numWorkingDays; j++)
                {
                    Console.WriteLine($"Day{j + 1}: {salaries[i][j]}");
                    totalSalary += salaries[i][j];
                }

                Console.WriteLine($"Total Salary: {totalSalary}\n");
            }
            Console.ReadKey();
        }
    }
}

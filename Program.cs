using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JagggedArrayExwecise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noc, nos;
            Console.WriteLine("Enter Number of Employees: ");
            noc = int.Parse(Console.ReadLine());
            string[][] employees = new string[noc][];
            for (int i = 0; i < noc; i++)
            {
                Console.WriteLine("Enter Number of Working days for Employee: " + (i + 1));
                nos = int.Parse(Console.ReadLine());
                employees[i] = new string[nos];
                for (int j = 0; j < nos; j++)
                {
                    Console.WriteLine($"Enter Employee Salary for Day: {j + 1} : ");
                    employees[i][j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($" Employee {i + 1} salary");
                Console.WriteLine("*********************************");
                for (int j = 0; j < employees[i].Length; j++)
                {
                    Console.WriteLine(employees[i][j]);
                    
                }
                int total = 0;
                for (int k = 0; k < employees[i].Length; k++)
                {
                    int v = int.Parse(employees[i][k]);
                    total = total + v;
                    
                }
                Console.WriteLine("Total Salary =" + total);
                Console.WriteLine("**********************************");
            }
            Console.ReadKey();
        }
    }
}

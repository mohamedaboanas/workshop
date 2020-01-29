
using System;
using System.Collections.Generic;

namespace Delegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public bool Attend { get; set; }
        public double Salary { get; set; }


        public delegate bool IsCondition(Employee emp);

        public static void Report(List<Employee> employees, IsCondition cond)
        {
            foreach (var employee in employees)
            {
                if (cond(employee))
                {
                    Console.WriteLine("Name : {0} ", employee.Name);
                }

            }
        }

        public static int BinarySeaarch(int[] employees, int left, int right)
        {
            var middle = (right + left) / 2;
            //do
            //{

                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[middle] == i)
                        return middle;
                }

            //} while (left <= right);

            return middle;
        }


    }
}

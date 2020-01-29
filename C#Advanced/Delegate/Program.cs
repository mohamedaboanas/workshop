using System;
using System.Collections.Generic;

using CAdvanced;

namespace Delegate
{
    class Program
    {

        static void Main(string[] args)
        {

            var fontStyle = (EnumFlageAttribute.FontStyle)3;

            var fontStyleTwice = EnumFlageAttribute.FontStyle.Bold | EnumFlageAttribute.FontStyle.Italic;

            var fontStyleTwiceC2 = EnumFlageAttribute.FontStyle.UnderLinw ^ EnumFlageAttribute.FontStyle.Italic;

            var fontStyleTwiceTH = fontStyleTwice ^ EnumFlageAttribute.FontStyle.Bold;

            Console.WriteLine(fontStyle + " " + fontStyleTwice + " " + fontStyleTwiceC2 + " " + fontStyleTwiceTH);
            Console.ReadLine();


            int[] numbers = new int[5];

            int[] stores = new[] { 1, 2, 3, 4, 5 };

            var k = 0;

            do
            {
                Console.WriteLine("  ", stores[k]);
                k++;
            } while (k > stores.Length);

            var j = 0;

            while (j < stores.Length)
            {
                Console.WriteLine("  ", stores[j]);
                j++;
            }


            string[] str1, str2;

            str1 = new string[] { "sd", "ser", "wer" };
            str2 = new string[2] { "eqwrew", "werwer" };



            var intarray = new[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // Excute with operation manager class & Enum
            var operManag = new OperationManager(20, 30);
            var result = operManag.Execute(Operation.Multiply);
            Console.WriteLine("The result of the operation is {0}", result);
            Console.ReadKey();

            // Excute with Operation manager class
            var excutionManager = new ExcutionManager();
            var operManager = new OperationManager(20, 10, excutionManager);
            var result1 = operManager.Execute2(Operation.Sum);
            Console.WriteLine("This is the result with excution manager {0}", result1);
            Console.ReadKey();


            var employeeList = new List<Employee>
            {
                new Employee {Attend = true, Id = 1, Job = "Accountant", Name = "Anas", Salary = 1000},
                new Employee {Id = 2, Name = "Hassan", Attend = false, Salary = 4000, Job = "Sales"},
                new Employee {Id = 3, Name = "Ismaiel", Attend = true, Salary = 6000, Job = "Accountant"},
                new Employee {Id = 4, Name = "Anas", Attend = false, Salary = 3000, Job = "Doctor"},
                new Employee {Id = 5, Name = "Mauson", Attend = true, Salary = 7000, Job = "Engenier"}

            };

            var isSalaryLamda = new Employee.IsCondition(emp => emp.Salary > 3000);

            var isSalaryFunc = new Employee.IsCondition(OperationManager.EmpCondition);

            Employee.Report(employeeList, emp => emp.Attend);
            Employee.Report(employeeList, emp => emp.Salary > 3000);
            Employee.Report(employeeList, emp => emp.Job.Contains("D"));

            Employee.Report(employeeList, isSalaryLamda);
            Employee.Report(employeeList, isSalaryFunc);

            var searhB = Employee.BinarySeaarch(stores, 1, 6);
            Console.WriteLine(searhB);

            Console.ReadLine();


            var customerList = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Joydip",
                    LastName = "Kanjilal",
                    State = "Telengana",
                    City = "Hyderabad",
                    Address = "Begumpet",
                    Country = "India"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Steve",
                    LastName = "Jones",
                    State = "OA",
                    City = "New York",
                    Address = "Lake Avenue",
                    Country = "US"
                }
            };


            Predicate<Customer> findCustomer = x => x.Id == 1;
            var customer = customerList.Find(findCustomer);
            Console.WriteLine(customer.FirstName + " " + customer.LastName);

            Action<string> action = Display;
            action("Hello Aamer!!");

            Func<int, double> funcCalc = CalculateHra;
            Console.WriteLine(funcCalc(2000));


            var customerName = new CustList<int>() { 2, 3, 4, 5, 6, 7, 9 };
            var getlist = customerName.FindList(x => x > 5);
            Console.WriteLine(getlist.Count);



            Stack<string> products = new Stack<string>();
            products.Push("Milk");
            products.Push("Meat");
            products.Push("Potatos");

            String[] productsList = products.ToArray();

            foreach (var product in productsList)
            {
                Console.WriteLine(product);
            }




        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }

        static double CalculateHra(int basic)
        {
            return basic * .4;
        }
    }
}

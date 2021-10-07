using System;
using System.Collections.Generic;
using System.Linq;

namespace TheCSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // employee List of object 
            List<Employee> employeesList = Employee.GetAllEmployees();

            /// https://dotnettutorials.net/course/linq/
            //////////////////////////////////////////////////////// Linq Sum in C#//////////////////////////////////////////////////////
            int ALLEmployeeSalarySum = employeesList.Sum(emp => emp.Salary);
            int ITEmployeeSalarySum = employeesList.Sum(emp=> { if (emp.Department == "IT") return emp.Salary; else return 0; });
            int SalesEmploueeSalarySum = employeesList.Where(emp => emp.Department == "Sales").Sum(emp => emp.Salary);
            // ITEmployeeSalarySum-SalesEmploueeSalarySum
            int ITMinusSalesSalarySum = employeesList.Sum(emp => { if (emp.Department == "IT") return emp.Salary; else return -emp.Salary;});



            Console.WriteLine(employeesList);
        }
    }
}


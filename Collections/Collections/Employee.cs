using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public String Designation { get; set; }
        public String Department {  get; set; }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> EmpList = new List<Employee>()
            {
                new Employee { Id = 14, Name ="Mukta", Salary = 10.4, Designation = "Developer", Department ="AIML"},
                new Employee { Id = 32, Name ="Vaish", Salary = 6.5, Designation = "Manager", Department="Financial" },
                new Employee { Id = 13, Name ="Ashwati", Salary = 7.4, Designation = "System Engineer", Department ="Testing"},
                new Employee { Id = 27, Name ="Anu", Salary = 12.6, Designation ="Data Scientist", Department = "AIML"},
                new Employee { Id = 23, Name ="Shri", Salary = 5.6, Designation =".Net Developer", Department = "Development"}
            };

            return EmpList;

        }

        public static void GetEmp()
        {
            //Method Syntax 
            var MethSyntax = Employee.GetAllEmployees();
            foreach (var emp in MethSyntax)
            {
                Console.WriteLine("ID: "+emp.Id+" "+"Name: "+emp.Name+" "+"Salary: "+emp.Salary+" "+"Designation: "+emp.Designation);
            }

            Console.WriteLine("_________________");
            //Query syntax
            var QuerySyntax = (from emp in Employee.GetAllEmployees() select emp);
            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine("ID: " + emp.Id + " " + "Name: " + emp.Name + " " + "Salary: " + emp.Salary + " " + "Designation: " + emp.Designation);
            }

            //Method syntax
            var MethSyntax1 = Employee.GetAllEmployees().Where(x => x.Department == "AIML").ToList();
            foreach (var emp in MethSyntax1)
            {
                Console.WriteLine(emp.Name);
            }

            //Query syntax
            var QuerySyntax1 = (from emp in Employee.GetAllEmployees() where emp.Designation == "Manager" select emp).ToList();
            foreach (var emp in QuerySyntax1)
            {
                Console.WriteLine(emp.Name);
            }

        }
    }
}

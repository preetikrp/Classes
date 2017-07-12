using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Company ignify = new Company ("Preeti", DateTime.Now);
            Console.WriteLine($"{ignify.Name} {ignify.CreatedOn}");
            Employee hana = new Employee("Shreeti", "july 2nd", "Admin");
            Employee tamela = new Employee("Eliza", "july 3rd", "Developer");
            Employee amrita = new Employee("Priya", "july 4th", "BA");
            ignify.AddEmployee(hana);
            ignify.AddEmployee(tamela);
            ignify.AddEmployee(amrita);
            ignify.ListEmployees();

      
        }
    }

    public class Company
    {
   
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void ListEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine(employee.Name);


            }
        }



        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);

        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        // Create a method that allows external code to remove an employee

        /*
        
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string companyName, DateTime taco )
        {
            Name = companyName;
            CreatedOn = taco;

        }

           
           


    }

    public class Employee
    {

        public string Name;
        public string Position;
        public string StartDate;
        public Employee(string employeeName, string startDate, string position)
        {
            Name = employeeName;
            StartDate = startDate;
            Position = position;
        }
    }
}


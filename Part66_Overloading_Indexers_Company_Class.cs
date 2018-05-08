
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kudvenkat.Part66.Overloading_Indexers
{
    public class Employee
    {
        public int    EmployeeId { get; set; }
        public string Name       { get; set; }
        public string Gender     { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            // Add new Employees
            listEmployees.Add(new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee() { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        } // End Constructor

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }

        public string this[string Gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.Gender == Gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployees)
                {
                    if(employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    } // End Company Class
} // End namespace
using System;

namespace EmployeeBL
{
    public abstract class BaseEmployee
    {
        public static int employeeCount;
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

        public BaseEmployee(int EmployeeID,string EmployeeName)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
        }

        public static int AddEmployee()
        {
            return employeeCount++;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID :" + EmployeeID);
            Console.WriteLine("Employeee Name :" + EmployeeName);
            Console.WriteLine("Salary :" + EmployeeSalary);
            Console.WriteLine("Employye Count  :" + employeeCount);
        }

        public abstract double CalculateSalary(int days);

    }
}

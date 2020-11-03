using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll !");
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.Name = "Terrisa";
            employee.Salary = 15000;
            employee.Gender = 'F';
            employee.PhoneNumber = "7596568964";
            employee.Address = "Nagpur";
            employee.Department = "R&D";
            employee.BasicPay = 1000;
            employee.Deductions = 100;
            employee.TaxablePay = 0;
            employee.IncomeTax = 0;
            employee.NetPay = 900;
            employeeRepo.AddEmployee(employee);
            //employeeRepo.GetEmployee();
        }
    }
}

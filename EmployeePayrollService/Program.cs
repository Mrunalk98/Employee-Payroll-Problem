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

            employee.Name = "Terrence";
            employee.Salary = 15000;
            employee.Gender = 'M';
            employee.PhoneNumber = "7596568964";
            employee.Address = "LA";
            employee.Department = "Marketing";
            employee.BasicPay = 20000;
            employee.Deductions = 2000;
            employee.TaxablePay = 0;
            employee.IncomeTax = 0;
            employee.NetPay = 18000;
            //employeeRepo.AddEmployee(employee);
            //employeeRepo.GetEmployee();
        }
    }
}

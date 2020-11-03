using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayrollService
{
    public class EmployeeRepo
    {
        public static string connectionString = @"data source=(localDB)\testDB; database=payroll_service;";

        SqlConnection connection = new SqlConnection(connectionString);

        public void GetEmployee()
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel();
                using(this.connection)
                {
                    string query = @"SELECT ID, Name, StartDate, Salary, Gender, PhoneNumber, Address, Department, BasicPay, Deductions, TaxablePay, IncomeTax, NetPay FROM employee_payroll;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModel.ID = dr.GetInt32(0);
                            employeeModel.Name = dr.GetString(1);
                            employeeModel.StartDate = dr.GetDateTime(2);
                            employeeModel.Salary = (float)dr.GetDecimal(3);
                            employeeModel.Gender = dr.GetString(4)[0];
                            employeeModel.PhoneNumber = dr.GetString(5);
                            employeeModel.Address = dr.GetString(6);
                            employeeModel.Department = dr.GetString(7);
                            employeeModel.BasicPay = (float)dr.GetDecimal(8);
                            employeeModel.Deductions = (float)dr.GetDecimal(9);
                            employeeModel.TaxablePay = (float)dr.GetDecimal(10);
                            employeeModel.IncomeTax = (float)dr.GetDecimal(11);
                            employeeModel.NetPay = (float)dr.GetDecimal(12);
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", employeeModel.ID, employeeModel.Name, employeeModel.StartDate, employeeModel.Salary, employeeModel.Gender, employeeModel.PhoneNumber, employeeModel.Address, employeeModel.Department);

                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found ");
                    }
                    dr.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool AddEmployee(EmployeeModel employee)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("spAddEmployeeDetail", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.Parameters.AddWithValue("@Gender", employee.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", employee.Address);
                    command.Parameters.AddWithValue("@Department", employee.Department);
                    command.Parameters.AddWithValue("@BasicPay", employee.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", employee.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", employee.TaxablePay);
                    command.Parameters.AddWithValue("@IncomeTax", employee.IncomeTax);
                    command.Parameters.AddWithValue("@NetPay", employee.NetPay);
                    this.connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        
    }
}

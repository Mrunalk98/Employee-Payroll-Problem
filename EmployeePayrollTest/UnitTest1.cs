using EmployeePayrollService;
using EmployeePayrollService.Model.PayrollModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {   
        [TestMethod]
        public void GivenPayrollDetails_UpdatePayrollData()
        {
            EmployeeRepo repo = new EmployeeRepo();
            PayrollUpdateModel payrollUpdateModel = new PayrollUpdateModel()
            {
                Payroll_ID = 2,
                BasicPay = 4000.00,
                Deductions = 200,
                IncomeTax = 100,
                Emp_ID = 1001
            };

            double Emp_BasicPay = repo.UpdateEmployeePayroll(payrollUpdateModel);

            Assert.AreEqual(payrollUpdateModel.BasicPay, Emp_BasicPay);

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollService.Model.PayrollModel
{
    public class PayrollUpdateModel
    {
        public int Payroll_ID { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double IncomeTax { get; set; }
        public int Emp_ID { get; set; }
    }
}

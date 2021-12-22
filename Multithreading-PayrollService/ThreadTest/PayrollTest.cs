using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Multithreading_PayrollService;
using System;

namespace ThreadTest
{
    [TestClass]
    public class PayrollTest
    {
        [TestMethod]
        public void GivenEmployeeDetail_WhenAnalyze_ShouldReturnDifferenceBetweenDate()
        {
            
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(Id: 1, Name: "Gyanendra", Phone: 123456789, Address: "Rewa", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 2, Name: "Hitesh", Phone: 123456789, Address: "Mumbai", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 3, Name: "Mohan", Phone: 123456789, Address: "Mumbai", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 4, Name: "Sohan", Phone: 123456789, Address: "Pune", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(Id: 5, Name: "Ramesh", Phone: 123456789, Address: "Mumbai", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));

            ThreadConfig threadConfig = new ThreadConfig();
            DateTime startDateTime = DateTime.Now;
            threadConfig.AddEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            threadConfig.AddEmployeeToPayroll(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}

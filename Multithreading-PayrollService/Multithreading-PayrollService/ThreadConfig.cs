using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading_PayrollService
{
   public class ThreadConfig
    {
        public List<EmployeeDetails> employeeDetailsList = new List<EmployeeDetails>();
        public void AddEmployeeToPayroll(List<EmployeeDetails> employeeDetailsList)
        {
            employeeDetailsList.ForEach(employeeData =>
            {
                Console.WriteLine(" Employee being added: " + employeeData.Name);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine(" Employee added: " + employeeData.Name);
            });
            Console.WriteLine(this.employeeDetailsList.ToString());
        }
        public void AddEmployeePayroll(EmployeeDetails emp)
        {
            employeeDetailsList.Add(emp);
        }
    }
}

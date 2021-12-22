using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddEmployeeToPayrollWithThread(List<EmployeeDetails> employeeDetailsList)
        {
            employeeDetailsList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine(" Employee being added: " + employeeData.Name);
                    this.AddEmployeePayroll(employeeData);
                    Console.WriteLine(" Employee added: " + employeeData.Name);
                });
                thread.Start();
            });
            Console.WriteLine(this.employeeDetailsList.Count());
        }
        public void AddEmployeePayroll(EmployeeDetails emp)
        {
            employeeDetailsList.Add(emp);
        }
    }
}

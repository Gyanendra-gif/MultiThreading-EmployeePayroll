using System;
using System.Collections.Generic;
using System.Text;

namespace Multithreading_PayrollService
{
   public class EmployeeDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
        public DateTime StartDate { get; set; }
        public EmployeeDetails(int Id, string Name, long Phone, string Address, string Department, 
            string Gender, double BasicPay, double Deduction, double TaxablePay, double IncomeTax, double NetPay)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
            this.Department = Department;
            this.Gender = Gender;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
        }
    }
}

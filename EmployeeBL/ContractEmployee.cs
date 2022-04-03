using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBL
{
    public class ContractEmployee:BaseEmployee
    {
        public DateTime ContractExpiryDate { get; set; }
        
        public int CustomeProp { get; set; }
        //CLR giving a built in defarult const

        public ContractEmployee(int epmID, string name)
            : base(epmID, name)
        {
            CustomeProp = 10;
        }

        public override double CalculateSalary(int hours)
        {
            EmployeeSalary = hours * 3000;
            return EmployeeSalary;

        }

    }
}

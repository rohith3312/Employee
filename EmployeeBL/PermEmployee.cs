using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBL
{

    public class PermEmployee:BaseEmployee
    {
        public bool AccessServerRoom;

        public PermEmployee(int epmID,string name,bool acess) 
            : base(epmID, name)
        {
            AccessServerRoom = acess;
        }
        public override double CalculateSalary(int days)
        {
             EmployeeSalary = days * 10000;
            return EmployeeSalary;

        }

    }
}

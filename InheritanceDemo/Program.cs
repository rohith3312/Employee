using EmployeeBL;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {/*
            BaseEmployee employee1 = new PermEmployee(1, "roh", true);
            BaseEmployee employee2 = new PermEmployee(1, "soh", true);
            BaseEmployee employee3 = new PermEmployee(1, "tarun", true);
            BaseEmployee employee4 = new ContractEmployee(1, "venky");
            BaseEmployee employee5 = new ContractEmployee(1, "chinku");
            BaseEmployee employee6 = new ContractEmployee(1, "pinku");
            BaseEmployee employee7 = new ContractEmployee(1, "Tharun");
            BaseEmployee employee8 = new ContractEmployee(1, "the");


            ArrayList n=new ArrayList();
            n.Add(employee1);
            n.Add(employee2);
            n.Add(employee3);
            n.Add(employee4);
            n.Add(employee5);
            n.Add(employee6);
            n.Add(employee7);
            n.Add(employee8);




            int contEmp = 0;

            int PermEmp = 0;

            foreach (BaseEmployee emp in n)
            {
                Type empType = emp.GetType();
                if (empType.Equals(typeof(ContractEmployee)))
                    contEmp++;
                else
                    PermEmp++;
            }
            Console.WriteLine(contEmp);
                    }

        private static void elseif(bool v)
        {
            throw new NotImplementedException();
        } */

            
            Dictionary<int, string> training_dict = new Dictionary<int, string>();
            training_dict.Add(1, "rohith");
            training_dict.Add(2, "tarun");
            foreach (KeyValuePair<int, string> item in training_dict)

            {
                Console.WriteLine(item.Key, item.Value);
            }





        }



    }
    public class Swapping<T>
    {
        public void swap(T data1,T data2)
        {
            T temp = data1;

            data1 = data2;
            data2 = temp;
            Console.WriteLine("data1 = " + data1 + "data2 =" + data2);
        }
    }
}


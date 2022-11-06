using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Department
    {
        public string[] Employees { get; set; }
        public Department(int size)
        {
            Employees = new string[size];
        }

        public Department ShallowCopy(int size)
        {
            Department newDept = new Department(size);
            newDept.Employees = this.Employees;
            return newDept;
        }

        public Department DeepCopy(int size)
        {
            Department newDept = new Department(size);
            newDept.Employees = new string[size];
            for(int i = 0; i < newDept.Employees.Length; i++)
            {
                newDept.Employees[i] = Employees[i];
            }
            return newDept;
        }

        public void Print()
        {
            Console.WriteLine("This Department Contains: ");
            for(int i = 0; i < Employees.Length; i++)
            {
                Console.Write($"{Employees[i]}\t");
            }
            Console.WriteLine();
        }
    }
}

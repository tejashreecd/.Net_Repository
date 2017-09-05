using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstApproach;

namespace CodeApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DeptContext())
            {
                Console.WriteLine("Add Department");
                var deptobj = new Dept { Id = 1, Name = "IT", Location = "Pune" };
                dept.departments.Add(deptobj);
                dept.SaveChanges();
                Console.WriteLine("Inserted department");
            }
            Console.ReadLine();
        }
    }
}

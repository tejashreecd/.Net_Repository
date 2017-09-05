using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFirstApproach;
namespace EntityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeeEntities())
            {
                //var emp = new Emp1();
                //emp.EmpID = 1;
                //emp.Name = "Mary";
                //emp.Salary = 10000;
                //EmpObj.Emp1.Add(emp);


                //emp = new Emp1();
                //emp.EmpID = 2;
                //emp.Name = "John";
                //emp.Salary = 20000;
                //EmpObj.Emp1.Add(emp);

                //emp = new Emp1();
                //emp.EmpID = 3;
                //emp.Name = "Mike";
                //emp.Salary = 15000;
                //EmpObj.Emp1.Add(emp);

                //Emp1 Emp1Obj = EmpObj.Emp1.First(i => i.EmpID == 2);
                //Emp1Obj.Name = "Moana";
                //Emp1Obj.Salary = 20000;

                Emp1 Emp2Obj = EmpObj.Emp1.First(i => i.EmpID == 2);
                EmpObj.Emp1.Remove(Emp2Obj);

                EmpObj.SaveChanges();

                Console.WriteLine("Records insterted");
            }
            Console.ReadLine();
        }
    }
}

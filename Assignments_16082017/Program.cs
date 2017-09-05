using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_16082017
{
    class Program
    {
        public delegate void TestDelegate(int a);
        static void Main(string[] args)
        {
            ///<third_assignment>
            Program p = new Program();
            CallDelegates(p);

            //<first_assignment>
            //SimpleInterest SIobj = new SimpleInterest();
            //CalculateSimpleInterest si = new CalculateSimpleInterest(SIobj.getTotalInterest);
            //CalculateSimpleInterest rate = new CalculateSimpleInterest(SIobj.getInterestRatePerYear);
            //CalculateSimpleInterest result;


            //Console.WriteLine("Enter principle amount");
            //int p = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number of years");
            //int n = Convert.ToInt32(Console.ReadLine());

            //// Console.WriteLine("Enter rate of interest");
            ////int r = Convert.ToInt32(Console.ReadLine());
            //rate(p, n);
            //result = si + rate;
            //si(p, n);


            ///<Func_Action>
            //Action<int, int> printNumber = new Action<int, int>(FuncAction.PrintNumbers);
            //printNumber(5, 20);

            //Func<int, int, int> add1 = new Func<int, int, int>(FuncAction.Addition);
            //int addition = add1(2, 5);
            //Console.WriteLine("Addition: {0}", addition);


            Console.ReadLine();

            
        }
        private static void CallDelegates(Program p)
        {

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee
            {
                ID = 1,
                Name = "ABC",
                DepartmentName = "CSE",
                ProjectName = "ElliMae"
            });
            employeeList.Add(new Employee
            {
                ID = 2,
                Name = "DEF",
                DepartmentName = "IT",
                ProjectName = "ElliMae"
            });
            employeeList.Add(new Employee
            {
                ID = 3,
                Name = "XYZ",
                DepartmentName = "IT",
                ProjectName = "Citi"
            });

            var emplList = employeeList.Any(c => c.ID == 1);
            var student = employeeList.Where(c => c.ID == 1).Select(c => new
            {
                customName = c.Name,

                customDept = c.DepartmentName,
                customProject = c.ProjectName
            }).FirstOrDefault();
            foreach (Employee person in employeeList.FindAll(c => (c.DepartmentName == "IT")).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tID: " + person.ID);
            }
            if (employeeList.Exists(e => e.Name == "ABC"))
            {
                Console.WriteLine("A person having name  'ABC' exists in our list");
            }
            Employee oPerson = employeeList.Find(e => (e.ID == 1));
            Console.WriteLine("The person having ID '1' is : " + oPerson.Name + " \t\t Department: " + oPerson.DepartmentName);
            int indexForXYZ = employeeList.FindIndex(e => e.Name == "XYZ");
            Console.WriteLine("The index position of a person having name 'XYZ' is : " + indexForXYZ);
            var obj2 = employeeList.Any(c => (c.Name == "ABC"));
            var obj3 = employeeList.GroupBy(item => item.DepartmentName).Select(lg =>
                                new {
                                    DepartmentName = lg.Key,
                                    Count = lg.Count(),

                                }).Last();

            Console.WriteLine("{0}", emplList);
            Console.WriteLine("{0}", student);
            Console.WriteLine("{0}", obj2);
            Console.WriteLine("{0}", obj3);

            //TestDelegate d1 = delegate (int a)
            //{
            //    Console.WriteLine(string.Format("Anonomyous method : {0}", a));

            //};
            //d1(15);

            //TestDelegate d2 = n =>
            //{
            //    Console.WriteLine(string.Format("lambda method: {0}", n));
            //};

            //d2(200);

        }
        public class Employee
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string DepartmentName { get; set; }
            public string ProjectName { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception_Handling;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            MathLib obj = new MathLib();
            Console.WriteLine("1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");

            ///<Generic_exception>
            //obj.test<ArgumentException>();


            Console.WriteLine("Enter your choice: ");
            int opt = int.Parse(Console.ReadLine());
            Console.WriteLine("Numbers:");

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        int result = obj.add(num1, num2);
                        Console.WriteLine("{0}", result);
                        break;
                    case 2:
                        int sub = obj.subtract(num1, num2);
                        Console.WriteLine("{0}", sub);
                        break;
                    case 3:
                        int mul = obj.multiply(num1, num2);
                        Console.WriteLine("{0}", mul);
                        break;
                    case 4:
                        int divide = obj.divide(num1, num2);
                        Console.WriteLine("{0}", divide);
                        break;
                }




            }

            catch (FormatException f)
            {
                Console.WriteLine("{0}", f.Message);
            }

            Console.ReadLine();




        }
    }
}

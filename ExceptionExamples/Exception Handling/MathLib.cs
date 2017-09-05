using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        { }
    }
    public class MathLib
    {
        int result;
        //bool flag = true;
        public int add(int num1, int num2)
        {
            result = num1 + num2;
            return result;
        }
        public int subtract(int num1, int num2)
        {
            result = num1 - num2;
            return result;
        }
        public int multiply(int num1, int num2)
        {
            result = num1 * num2;
            return result;
        }
        public int divide(int num1, int num2) 
        {
            try
            {
                result = num1 / num2;
                if (num1 < num2)
                {
                    throw (new CustomException("Number 1 is greater than number2"));
                }
                //IConvertible conv = flag;
                //Char ch = conv.ToChar(null);
                //string str = null;
                //Console.WriteLine("Length: {0}", str.Length);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            catch (InvalidCastException i)
            {
                Console.WriteLine("{0}", i.Message);
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine("{0}", n.Message);
            }
            catch (CustomException c)
            {
                Console.WriteLine("{0}", c.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            return result;
        }
        public void test<T>() where T : Exception, new()
        {
            try
            {
                throw new T();
            }
            catch (T e)
            {
                Console.WriteLine("Caught passed in exception type: {0}", e.Message);
            }
            catch (Exception )
            {
                Console.WriteLine("Caught general exception");
            }
        }
    }
}

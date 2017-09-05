using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_16082017
{
    public delegate void CalculateSimpleInterest(int p, int n);
    public class SimpleInterest
    {
        int rate;

        public void getTotalInterest(int p, int n/*,int r*/)
        {
            int si = 0;
            si = (p * n * rate) / 100;
            Console.WriteLine("Principle:{0}\nNumber of years:{1}\nRate of interest:{2}", p, n, rate);
            Console.WriteLine("Simple Interest:{0}", si);

        }

        public void getInterestRatePerYear(int p, int n)
        {
            Console.WriteLine("Enter rate of interest per year");
            rate = Convert.ToInt32(Console.ReadLine());

        }

    }
}

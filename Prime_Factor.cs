using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Prime_Factor
    {
        public void Prime()
        {
            int n;
            Console.WriteLine("please enter a Number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n % 2 == 0)
            {
            Console.WriteLine("2");

                n = n / 2;
            }
            for (int i = 3; i*i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine("{0}",i);
                    n = n / i;
                }
            }
            if (n > 2)
            Console.WriteLine("{0}", n);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Harmonic_Number
    {
        public void Find_Harmonic()
        {
            int n;
            Console.WriteLine("please enter a Number");
            n = Convert.ToInt32(Console.ReadLine());

            double harmonic = 1.00;
            for (int i = 2; i <= n; i++)
            {
                harmonic += (float)1 / i;
            }
            Console.WriteLine("The Number is:{0}",harmonic);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Power_2
    {
        public void Find_Power_2()
        {
            int n;
            int power=1;
            Console.WriteLine("please enter a Number");
            n = Convert.ToInt32(Console.ReadLine());


            for(int i=1;i<=n;i++)
            {
                power *= 2;
            }
            Console.WriteLine("Power of Two is:{0}",power);

        }
    }
}

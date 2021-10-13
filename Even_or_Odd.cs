using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Even_or_Odd
    {
        public void Even_Odd()
        {
            int n;
            Console.WriteLine("please enter a Number");
            n = Convert.ToInt32(Console.ReadLine());
              
             if(n%2==0)
            {
                Console.WriteLine("Its  a Even Number");
            }
            else
            {
                Console.WriteLine("Its  a Odd Number");
            }
        }
    }
}

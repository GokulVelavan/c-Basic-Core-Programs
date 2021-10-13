using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
   public class Leap_Year
    {
        public void Find_Leap_Year()
        {
            int n;
            Console.WriteLine("please enter a Year");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 4 == 0)
            {
                Console.WriteLine("Its a Leap Year");
            }
            else
            {
                Console.WriteLine("Sorry Its not a Leap Year");

            }
        }
        
    }
}

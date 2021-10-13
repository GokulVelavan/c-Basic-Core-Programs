using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Swap_Two_Numbers
    {
        public void swap()
        {
            int n1, n2;
            Console.WriteLine("please enter a Numbers to be Swapped");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("The Swapped  Numbers are:{0}",n1);
            Console.WriteLine(n2);



        }
    }
}

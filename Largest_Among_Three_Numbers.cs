using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Largest_Among_Three_Numbers
    {
        public void Largest()
        {
            int n1, n2, n3;
            int max = -1;
            Console.WriteLine("please enter 3 Numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            if(n1>max)
            {
                max = n1;
            }
            if (n2 > max)
            {
                max = n2;
            }
            if (n3 > max)
            {
                max = n3;
            }
            Console.WriteLine("The max Number is:{0}",max);



        }
    }
}

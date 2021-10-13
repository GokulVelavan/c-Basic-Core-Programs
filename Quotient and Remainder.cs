using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Quotient_and_Remainder
    {
        public void Quotient_Remainder()
        {
            int n1, n2, Quotient,Remainder;
            Console.WriteLine("please enter the Divisible Number & Dividing Number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Quotient = n1 / n2;
            Remainder = n1 % n2;
            Console.WriteLine("The   Quotient is :{0}",Quotient);
            Console.WriteLine("The   Remainder is :{0}", Remainder);



        }

    }
}

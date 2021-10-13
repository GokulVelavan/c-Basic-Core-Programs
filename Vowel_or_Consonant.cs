using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    public class Vowel_or_Consonant
    {

        public void Vowel_Consonant()
        {
            Console.WriteLine("please enter a Alphabet");

            string s = Console.ReadLine();
            if(s=="a"||s=="A"||s=="e"||s=="E"||s=="i"||s=="I"||s=="o"||s=="O"||s=="u"||s=="U")
            {
                Console.WriteLine("Its a Vowel");
            }
            else
            {
                Console.WriteLine("Its a Consonant");
            }

        }
    }
}

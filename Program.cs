using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
    class Program
    {
        public const int FLIP_COIN = 1;
        public const int LEAP_YEAR = 2;
        public const int POWER_2 = 3;
        public const int HARMONIC_NUMBER = 4;
        public const int PRIME_FACTOR = 5;
        public const int QUOTIENT_AND_REMAINDER = 6;
        public const int SWAP_TWO_NUMBERS = 7;
        public const int EVEN_OR_ODD = 8;
        public const int VOWEL_OR_CONSONANT = 9;
        public const int LARGEST_AMONG_THREE_NUMBERS= 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Please Select The Number");
            Console.WriteLine("1.Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2.Find the year is Leap Year or not");
            Console.WriteLine("3.Find the Power of 2");
            Console.WriteLine("4.Find the  Harmonic_Number");
            Console.WriteLine("5.Find the  Prime factor");
            Console.WriteLine("6.Find the Quotient_and_Remainder");
            Console.WriteLine("7.Enter the number to be Swapped");
            Console.WriteLine("8.Find the Number is Even or Odd");
            Console.WriteLine("9.Find the Alphabet is Vowel_or_Consonant");
            Console.WriteLine("10.Find the Largest_Among_Three_Numbers");

            int SELECT =Convert.ToInt32 (Console.ReadLine());
            switch(SELECT)
            {
                case FLIP_COIN:
                    Coin obj = new Coin();
                    obj.Coin_Percentage();
                    break;
                case LEAP_YEAR:
                    Leap_Year obj2 = new Leap_Year();
                    obj2.Find_Leap_Year();
                    break;
                case POWER_2:
                    Power_2 obj3 = new Power_2();
                    obj3.Find_Power_2();
                    break;
                case HARMONIC_NUMBER:
                    Harmonic_Number obj4 = new Harmonic_Number();
                    obj4.Find_Harmonic();
                    break;
                case PRIME_FACTOR:
                    Prime_Factor obj5 = new Prime_Factor();
                    obj5.Prime();
                    break;

                case QUOTIENT_AND_REMAINDER:
                    Quotient_and_Remainder obj6 = new Quotient_and_Remainder();
                    obj6.Quotient_Remainder();
                    break;
                case SWAP_TWO_NUMBERS:
                    Swap_Two_Numbers obj7 = new Swap_Two_Numbers();
                    obj7.swap();
                    break;
                case EVEN_OR_ODD:
                    Even_or_Odd obj8 = new Even_or_Odd();
                    obj8.Even_Odd();
                    break;
                case VOWEL_OR_CONSONANT:
                    Vowel_or_Consonant obj9 = new Vowel_or_Consonant();
                    obj9.Vowel_Consonant();
                    break;
                case LARGEST_AMONG_THREE_NUMBERS:
                    Largest_Among_Three_Numbers obj10 = new Largest_Among_Three_Numbers();
                    obj10.Largest();
                    break;
                default:
                    Console.WriteLine("Please Select The Valid Number");
                    break;

            }

            Console.ReadLine();
        }
    }
}

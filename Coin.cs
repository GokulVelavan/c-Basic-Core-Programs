using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE_FUNCTIONAL_PROGRAMMING_C_SHARP
{
   public class Coin
    {
        public const int TAILS = 0;
        public const int HEADS = 1;
       public void Coin_Percentage()
        {
            int COUNT;
            int COIN;
            int HEAD_COUNT = 0;
            int TAIL_COUNT = 0;
            int HEAD_COUNT_PERCENTAGE;
            int TAIL_COUNT_PERCENTAGE;

            Console.WriteLine("Please Enter the Number");
            COUNT = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < COUNT; i++)
            {
                Random random = new Random();
                COIN = random.Next(0,2);
                if (COIN==HEADS)
                {
                    HEAD_COUNT++;
                }
                else
                {
                    TAIL_COUNT++;
                }
            }

            TAIL_COUNT_PERCENTAGE = (TAIL_COUNT*100 / COUNT) ;
            HEAD_COUNT_PERCENTAGE = (HEAD_COUNT * 100 / COUNT);

            Console.WriteLine("HEAD_COUNT:{0}",HEAD_COUNT_PERCENTAGE);
            Console.WriteLine("TAIL_COUNT:{0}",TAIL_COUNT_PERCENTAGE);

            Console.ReadLine();
        }
    }
}

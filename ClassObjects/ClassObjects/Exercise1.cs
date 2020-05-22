using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjects
{
    class Exercise1
    {
        //1.Class yaradırıq və həmin klassda içərisində mənfi müsbət ədədlər olan integer tipindən array yazırıq(Field kimi) 
       //Metod yazırıq, həmin metod verilmiş arrayda müsbət, mənfi və 0-a bərabər olan ədədlərin sayını tapsın
        //Müsbətlərin sayı, Mənfilərin sayı, Sıfırların sayı).(Obyekt yaradib metodu cagirmaqla)
        public int[] arr3 = { 3, 45, 6, 8, 0, -5, 0, 3 };


        public void FindCounts()
        {
            int poscount = 0;
            int negcount = 0;
            int zerocount = 0;
            foreach (int item in arr3)
            {
                if (item > 0)
                {
                    poscount++;

                }
                else if (item == 0)
                {
                    zerocount++;
                }
                else
                {
                    negcount++;
                }
            }

            Console.WriteLine($"Musbet ededlerin sayi:{poscount},Menfi ededlerin sayi:{negcount},Sifirlarin sayi:{zerocount}");
        }
    }
}

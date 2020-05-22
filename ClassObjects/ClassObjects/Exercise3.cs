using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjects
{
    class Exercise3
    {//3.İki return metodu olan klass yaradırıq.Metodun biri verilmiş aralığdakı ədədlərin cəmini tapır, ikincisi aralıqdakı ədədlərin sayını.
     //2,4,6,...94. (Obyekt yaradib metodu cagirmaqla).
        public int FindSum(int number)
        {
            int sum = 0;
            for (int i = 2; i <= number; i += 2)
            {
                sum += i;
            }

            return sum;
        }


        public int FindCount(int number)
        {
            int count = 0;
            for (int i = 2; i <= number; i += 2)
            {
                count++;
            }

            return count;
        }
    }
}

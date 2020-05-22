using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjects
{
    class Factorial:Exercise2
    {//2-ci tapshiriq
        public void FindFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

    }
}

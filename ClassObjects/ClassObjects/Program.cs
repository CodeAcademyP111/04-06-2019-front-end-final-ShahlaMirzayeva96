using System;

namespace ClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1 exercise1 = new Exercise1();
            //int[] arr2 = { 2, 8, 9, 0, -4, 5, 0, -3 };
            //exercise1.FindCounts(arr2);

            //Factorial factorial = new Factorial();
            //factorial.FindFactorial(5);

            //Exercise3 exercise3 = new Exercise3();
            //Console.WriteLine(exercise3.FindSum(94));
            //Console.WriteLine(exercise3.FindCount(94));

            Exercise4 exercise4 = new Exercise4("Aynur","Abbasova",1990);

            exercise4.FindAge(2020);

        }
    }
}

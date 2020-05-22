using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjects
{
    class Exercise4
    {
        public string Name{ get; set; }

        public string Surname { get; set; }

        public int BirthdayYear { get; set; }


        public Exercise4(string name,string surname,int birthdayYear)
        {
            Name = name;
            Surname = surname;
            BirthdayYear = birthdayYear;
        }

        public void FindAge(int nowyear)
        {
            int age = 0;

            age = nowyear - BirthdayYear;

            Console.WriteLine($"Ad:{Name},Soyad:{Surname},Yash:{age}");
        }
    }
}

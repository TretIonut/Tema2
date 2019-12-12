using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    class Program
    {
        public enum GenderStates
        {
            Male,
            Female
        }

        static void Main(string[] args)
        {
            int BirthYear, BirthMonth, BirthDay;

            Console.WriteLine("Insert your birth year in the following format 'YYYY':");
            string YearString = Console.ReadLine();
            Console.WriteLine("Insert your birth month:");
            string MonthString = Console.ReadLine();
            Console.WriteLine("Insert your birth day:");
            string DayString = Console.ReadLine();
            Console.WriteLine("Insert your gender (M/F):");
            string GenderString = Console.ReadLine();

            BirthYear = int.Parse(YearString);
            BirthMonth = int.Parse(MonthString);
            BirthDay = int.Parse(DayString);

            DateTime BirthDate = new DateTime(BirthYear, BirthMonth, BirthDay);
            DateTime now = DateTime.Now;

            TimeSpan DateDiff = now - BirthDate;
            int AgeOfUser = DateDiff.Days / 365;

            Console.WriteLine("Age of user: {0}", AgeOfUser);

            int? GenderNumeric;
            GenderNumeric = null;

            if (GenderString=="M" || GenderString== "m")
            {
                GenderStates currentState = GenderStates.Male;
                GenderNumeric = (int)currentState;
            }
            else if (GenderString == "F" || GenderString== "f")
            {
                GenderStates currentState = GenderStates.Female;
                GenderNumeric = (int)currentState;
            }

            if (GenderNumeric.HasValue)
            {
                bool RetiredUser = true;
                if (GenderNumeric == 0)
                {
                    if (AgeOfUser < 65)
                    {
                        Console.WriteLine("You will retire at 65 yo.");
                        RetiredUser = false;
                    }
                }
                else if (GenderNumeric == 1)
                {
                    if (AgeOfUser < 63)
                    {
                        Console.WriteLine("You will retire at 63 yo.");
                        RetiredUser = false;
                    }
                }
                if (RetiredUser)
                {
                    Console.WriteLine("Retired");
                }
            }
           
        }
    }
}

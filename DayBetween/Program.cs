using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.WriteLine("What is the first date?");
            string firstDateInput = Console.ReadLine();
            
            Console.WriteLine("What is the second date?");
            string secondDateInput = Console.ReadLine();
            DateTime firstDate = DateTime.Parse(firstDateInput);
            DateTime secondDate = DateTime.Parse(secondDateInput);

            int countdown = DaysBetween(firstDate, secondDate);
            Console.WriteLine(countdown);
           
            Console.ReadLine();
        }
        public static int DaysBetween (DateTime firstDate, DateTime secondDate)
        {


            TimeSpan countdown;
            if(firstDate > secondDate)
            {
                countdown = firstDate.Subtract(secondDate);
            }
            else
            {
                countdown = secondDate.Subtract(firstDate);
            }
           
            string daysBetween = countdown.TotalDays.ToString();
            int daysBetweenint = Convert.ToInt32(daysBetween);

            return daysBetweenint;
        }

        // TODO: Create that has a method that counts the number of days between two different dates.
    }
}

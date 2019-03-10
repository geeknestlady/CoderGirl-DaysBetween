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
            
            string countdown = DaysBetween(firstDateInput, secondDateInput);
            Console.WriteLine(countdown);
           
            Console.ReadLine();
        }
        public static string DaysBetween (string firstDateInput, string secondDateInput)
        {
            DateTime firstDate = DateTime.Parse(firstDateInput);
            DateTime secondDate = DateTime.Parse(secondDateInput);
            TimeSpan countdown = firstDate.Subtract(secondDate);
            string daysBetween = countdown.TotalDays.ToString();

            return daysBetween;
        }

        // TODO: Create that has a method that counts the number of days between two different dates.
    }
}

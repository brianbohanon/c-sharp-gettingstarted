using System;

namespace birthday_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(2000, 8, 19);

            TimeSpan countdown = birthday - DateTime.Today;
            
            Console.WriteLine($"If you were born on {birthday}, you are {countdown.TotalDays} days old");
        }
    }
}

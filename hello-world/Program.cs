using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Brian";
            var greeting = "Hello";
            string greeting2 = "Top o' the morning";
            string greet1 = $"Hello {name}!"; // Recommended method for string interpolation
            string greet2 = "Hello " + name + "!"; // Hello Brian!
            string greet3 = String.Format("Hello {0}!", name); // Hello Brian!
            string greetTemplate = "Hello **NAME**!";
            string greet4 = greetTemplate.Replace("**NAME**", name); // Hello Brian

            //string string1; //current value is null
            //string1 = "Hello";
            //string string2 = "Hello";

            //string empty1 = "";
            //string empty2 = String.Empty;

            string emptyString = String.Empty;
            string nullString = null;

            string one = "abc";
            string two = "123";
            string combined = one + two; // "abc123"

            string original = "Test string";
            string capital = original.ToUpper(); // TEST STRING
            string lower = original.ToLower(); // test string
            string lower2 = "Another Test".ToLower(); // another test

            string input = " Steve "; //has a space at the start and end
            string clean1 = input.TrimStart(); // "Steve "
            string clean2 = input.TrimEnd(); // " Steve"
            string clean3 = input.Trim(); // "Steve"
            string shortversion = input.Trim().Substring(0,3); // Ste

            var loud = $"{greeting2} {name}!".ToUpper();
            var quiet = $"{greeting2} {name}.".ToLower();

            var currentTime = DateTime.Now; // current time
            var today = DateTime.Today; // currrent date - time is midnight
            var someDate = new DateTime(2016,7,1); //1 July 2016, midnight
            var someMoment = new DateTime(2016,7,1,8,0,0);  // 1 July 2017, 08:00.00
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
            var someDay = DateTime.Parse("7/1/2016");
            var someTime = new DateTime(2016,7,1,11,10,9); // 1 July 2016 11:10:09 AM

            int year = someTime.Year; //2016
            int month = someTime.Month; //7
            int day = someTime.Day; // 1
            int hour = someTime.Hour;
            int minute = someTime.Minute;
            int second = someTime.Second;

            DateTime nextYear = new DateTime(DateTime.Today.Year+1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.WriteLine(hour);
            Console.WriteLine(minute);
            Console.WriteLine(second);

            Console.WriteLine(currentTime);
            Console.WriteLine(today);
            Console.WriteLine(someDate);
            Console.WriteLine(someMoment);
            Console.WriteLine(tomorrow);
            Console.WriteLine(yesterday);
            Console.WriteLine(someDay);

            Console.WriteLine($"{greeting2} {name}!");

            Console.WriteLine(greet1);
            Console.WriteLine(greet2);
            Console.WriteLine(greet3);
            Console.WriteLine(greet4);


            Console.WriteLine(input);
            Console.WriteLine(clean1);
            Console.WriteLine(clean2);
            Console.WriteLine(clean3);
            Console.WriteLine(shortversion);

            Console.WriteLine(original);
            Console.WriteLine(capital);
            Console.WriteLine(lower);
            Console.WriteLine(lower2);

            Console.WriteLine(combined);

            Console.WriteLine(emptyString); //prints nothing
            Console.WriteLine(nullString); //prints nothing

            // this line will print 0
            Console.WriteLine($"1st string is {emptyString.Length} characters long.");

            //this line will throw an exception (uncomment to confirm)
            //Console.WriteLine($"2nd string is {nullString.Length} characters long");

            Console.WriteLine($"{greeting} {name}!");
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Print Welcome Message */
            Console.WriteLine("CSharpExercises");
            Console.WriteLine();

            /* Test exercises (Uncomment tests to run them) (Ctrl + K,C to mass comment, Ctrl + K,U to mass uncomment) */
            Assert("HelloWorld() should return \"Hello World!\"", Exercises.HelloWorld() == "Hello World!");
            Assert("SayHello(\"John\") should return \"Hello John!\"", Exercises.SayHello("John") == "Hello John!");
            Assert("Sum(10,12) should return 22", Exercises.Sum(10, 12) == 22);
            Assert("Divide(10,5) should return 2", Exercises.Divide(10, 5) == 2);
            Assert("CanOpenCheckingAccount(16) should return false", Exercises.CanOpenCheckingAccount(16) == false);
            Assert("CanOpenCheckingAccount(17) should return false", Exercises.CanOpenCheckingAccount(17) == false);
            Assert("CanOpenCheckingAccount(18) should return true", Exercises.CanOpenCheckingAccount(18) == true);
            Assert("CanOpenCheckingAccount(19) should return true", Exercises.CanOpenCheckingAccount(19) == true);
            Assert("GetFirstName(\"John Smith\") should return \"John\"", Exercises.GetFirstName("John Smith") == "John");
            Assert("GetFirstName(\"Ann-Marie Simpson\" should return \"Ann-Marie\"", Exercises.GetFirstName("Ann-Marie Simpson") == "Ann-Marie");
            Assert("ReverseStringHard() should reverse the string", Exercises.ReverseStringHard(Constants.Quote) == Constants.QuoteReversed);
            Assert("ReverseStringEasy() should reverse the string", Exercises.ReverseStringEasy(Constants.Quote) == Constants.QuoteReversed);
            Assert("PrintTimesTable(9) should print correctly", Exercises.PrintTimesTable(9) == Constants.TimesTableFor9);
            Assert("ConvertKelvinToFahrenheit(300) should return 80.33", Exercises.ConvertKelvinToFahrenheit(300) == 80.33);
            Assert("GetAverageHard(new int[] { 10, 20, 30, 40, 50, 60, 80 }) should return 41.428571428571431", Exercises.GetAverageHard(new int[] { 10, 20, 30, 40, 50, 60, 80 }) == 41.428571428571431);
            Assert("GetAverageEasy(new int[] { 10, 20, 30, 40, 50, 60, 80 }) should return 41.428571428571431", Exercises.GetAverageEasy(new int[] { 10, 20, 30, 40, 50, 60, 80 }) == 41.428571428571431);
            Assert("DrawTriangle(8, 5) should draw correctly", Exercises.DrawTriangle(8, 5) == Constants.TriangleFor8and5);
            Assert("GetMilesPerHour(200, 2, 30, 45) should return \"80MPH\"", Exercises.GetMilesPerHour(200, 2, 30, 45) == "80MPH");
            Assert("GetMilesPerHour(200, 2, 29, 0) should return \"81MPH\"", Exercises.GetMilesPerHour(200, 2, 29, 0) == "81MPH");
            Assert("IsVowel('a') should return true", Exercises.IsVowel('a') == true);
            Assert("IsVowel('e') should return true", Exercises.IsVowel('e') == true);
            Assert("IsVowel('i') should return true", Exercises.IsVowel('i') == true);
            Assert("IsVowel('o') should return true", Exercises.IsVowel('o') == true);
            Assert("IsVowel('u') should return true", Exercises.IsVowel('u') == true);
            Assert("IsVowel('b') should return false", Exercises.IsVowel('b') == false);
            Assert("IsVowel('z') should return false", Exercises.IsVowel('z') == false);
            Assert("IsVowel((char)97) should return true", Exercises.IsVowel((char)97) == true); // http://www.dotnetperls.com/char
            Assert("IsConsonant('a') should return false", Exercises.IsConsonant('a') == false);
            Assert("IsConsonant('e') should return false", Exercises.IsConsonant('e') == false);
            Assert("IsConsonant('i') should return false", Exercises.IsConsonant('i') == false);
            Assert("IsConsonant('o') should return false", Exercises.IsConsonant('o') == false);
            Assert("IsConsonant('u') should return false", Exercises.IsConsonant('u') == false);
            Assert("IsConsonant('b') should return true", Exercises.IsConsonant('b') == true);
            Assert("IsConsonant('z') should return true", Exercises.IsConsonant('z') == true);
            Assert("IsConsonant((char)97) should return false", Exercises.IsConsonant((char)97) == false); // http://www.dotnetperls.com/char
            Assert("CollatzConjecture(27) should return 111", Exercises.CollatzConjecture(27) == 111);
            Assert("GetOccurences(\"Hello World!\", \"World\") should return 1", Exercises.GetOccurences("Hello World!", "World") == 1);
            Assert("GetNext7Days() should return next 7 days", JsonConvert.SerializeObject(Exercises.GetNext7Days(DateTime.Parse("08/22/2016"))) == JsonConvert.SerializeObject(Constants.Next7Days));
            Assert("IsInLeapYear(2000) should return true", Exercises.IsInLeapYear(2000) == true);
            Assert("IsInLeapYear(1904) should return true", Exercises.IsInLeapYear(1904) == true);
            Assert("IsInLeapYear(1900) should return false", Exercises.IsInLeapYear(1900) == false);
            Assert("IsInLeapYear(1901) should return false", Exercises.IsInLeapYear(1901) == false);
            Assert("MortgageCalculator(300000, 3.8, 30, 12) should return 1397.87", Exercises.MortgageCalculator(300000, 3.8, 30, 12) == 1397.87);
            Assert("DuckGoose(100) should print correctly", Exercises.DuckGoose(100) == Constants.DuckGooseResult);

            /* Prompt user to exit */
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        /// <summary>
        /// Asserts that a condition is true and prints a message to the console.
        /// </summary>
        /// <param name="exerciseName">The name of the exercise</param>
        /// <param name="condition">The condition to assert</param>
        static void Assert(string exerciseName, bool condition)
        {
            if (condition)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[PASS] - {exerciseName}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FAIL] - {exerciseName}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

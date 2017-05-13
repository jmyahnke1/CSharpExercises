using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";  //Append name to Hello!
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int i, int j)
        {
            return i + j;   //Return a sum
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public  static decimal Divide(decimal x, decimal y)
        {
            if (y == 0m)
                return decimal.MaxValue;   //Just a small divide by zero check!
            return x / y;   //return a divided decimal number.
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            return (age >= 18 ? true : false);  //If great equal to 18 return true, else return false.
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string fullName)
        {
            string[] splitName = fullName.Split(' ');   //Split the string into an array
            return splitName[0];                        //Assume first name is at 0 index.
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string stringToReverse)
        {
            int lngth = stringToReverse.Length;                     //Find the length of the string
            char[] stringArray = new char[lngth];                   //Create a char array to store the string for maniulation.
            for (int index = 0; index < lngth; index++)
                stringArray[index] = (char)stringToReverse[index];  //Copy the chars from string to array
            int firstPos = 0;                                       //Set up front and last pointers.
            int lastPos = lngth - 1;
            char temp;
            while (firstPos < lastPos)                              //Go through and swap chars at the current index points until the front index is greater than the last index. 
            {
                temp = stringArray[firstPos];                       //Swapping starts here.
                stringArray[firstPos] = stringArray[lastPos];
                stringArray[lastPos] = temp;
                firstPos++;                                         //Increment the front index, decrement the last position index.
                lastPos--;
            }
            string revString = new string(stringArray);             //Make a string from the array and return;
            return revString;

        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string stringToReverse)
        {
            //Using methods, convert the string to an array, call the built-in array reserve method, and turn it into another array that will be passed to 
            //string constructor and the new string is returned.
            return new string(stringToReverse.ToCharArray().Reverse().ToArray());
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
            * 10 * 1 = 10
            * 10 * 2 = 20
            * 10 * 3 = 30
            * 10 * 4 = 40
            * 10 * 5 = 50
            * 10 * 6 = 60
            * 10 * 7 = 70
            * 10 * 8 = 80
            * 10 * 9 = 90
            * 10 * 10 = 10 */

        public static string PrintTimesTable(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int index = 1; index <= 10; index++)   //Go from 1 to 10
            {   
                int value = n * index;                  //Calculate the nuerical value
                sb.Append(n.ToString() + " * " + index.ToString() + " = " + value.ToString());  //Append it to the cuurent string
                if (index < 10)
                    sb.Append(Environment.NewLine);     //If the last iteration, don't append the newline.
            }
            return sb.ToString();                       //Return the whole kit and kaboodle.
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvin)
        {
            return Math.Round(kelvin * 9.0 / 5.0 - 459.67, 2);      //Pretty straight forward calculation.
        }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard (int[] table)
        {
            double average = 0.0;                           //Simple average calculation
            int index;
            for (index = 0; index < table.Length; index++)  //Master loop
            {
                average += (double)table[index];            //Sum the values into a double
            }
            return average / index;                         //Calc the average and return it.
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] table)
        {
            return (double) table.Sum() / table.Length;     //Built in calculation. Force the sum to double, or you will get an int back.
        }

        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        public static string DrawTriangle(int number, int width)
        {
            StringBuilder sb = new StringBuilder();
            char numberChar = number.ToString()[0];         //Get the number into a char
            for (int index = width; index > 0; index--)     //Count down for loop.
            {
                for (int count = 0; count < index; count++) //Append the numbr chat coutn times.
                {
                    sb.Append(numberChar);
                }
                if (index > 1)                              //Append a <cr> unless its the last one.
                    sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour (double dist, int hours, int minutes, int seconds)
        {
            double dblMPH = (dist / ((hours * 3600) + (minutes * 60) + seconds)) * 3600.0;  //Make into distance per second, then into distance per hour.
            return Math.Round(dblMPH, 0).ToString() + "MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char ch)
        {
            bool isVowel = "aeiouAEIOU".IndexOf(ch) >= 0;
            return isVowel;
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char ch)
        {
            return !IsVowel(ch);        //If we know it's not a vowel, it must be a consonant!!
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int n)
        {
            int iteration = 0;
            while (n > 1)           //Great than 1 loop!
            {
                if (n % 2 == 0)     //Test for even value, divy by half.
                    n /= 2;
                else
                    n = 3 * n + 1;  //Else triple it and add 1
                iteration++;        //Bump us the counter.
            }
            return iteration;       //Return the conjecture.
        }
        // 16.b  GetOccurences may have been left off by accident.  Count the number of times a word occurs in a string.
        public static int GetOccurences(string sentence, string wordToFind)
        {
            List<char> list = new List<char>();
            int wordCount = 0;
            for (byte byt = 0; byt < 128; byt++)        //I just built a list of characters to split on, punctuation and white space.
            {
                if (char.IsWhiteSpace((char) byt) || char.IsPunctuation((char)byt))
                {
                    list.Add((char)byt);
                }
            }
            string[] words = sentence.Split(list.ToArray());    //Spilt the words.
            foreach (string word in words)                      //Loop though the words.
            {
            if (word.Contains(wordToFind))                      //If the search word found, bump up the count.
                wordCount++;
            }

            return wordCount;                                   //Return the count.
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime dt)
        {
            DateTime[] returnArray = new DateTime[7];                   //Build and array of dates.
            returnArray[0] = dt;                                        //Save the orgincal date.
            for (int index = 1; index <= 6; index++)                    //Calcualte 6 more.
            {
                returnArray[index] = returnArray[index - 1].AddDays(1); //Add a day based on a previous day.
            }
            return returnArray;                                         //Return the array.
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int dt)
        {
            if (((dt % 4 == 0) && (dt % 100 != 0)) || (dt % 400 == 0))  //Leap year calculation.  Thanks Google.  You know all!
                return true;
            else
                return false;
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double loan, double intRate, int years, int period)
        {
            // monthly interest rate                                        //From the Javascript project.
            double monthlyInterestRate = (intRate / 100) / period;
            // number of payments
            int numberOfPayments = years * period;
            // compounded interest rate
            double compoundedInterestRate = Math.Pow((1 + (double) monthlyInterestRate), numberOfPayments);
            // interest quotient
            double interestQuotient = (monthlyInterestRate * compoundedInterestRate) / (compoundedInterestRate - 1);
            // final calculation
            double monthlyPayment = loan * interestQuotient;
            return Math.Round(monthlyPayment, 2);
        }
        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.

        public static string DuckGoose(int count)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder work = new StringBuilder();
            for (int index = 1; index <= count; index++) {      //Count from 1 to 100.
                if (index % 3 == 0)                             //If divisible by 3 we are a Duck.
                    work.Append("Duck");
                if (index % 5 == 0)                             //If divisible by 5 we are a Goose.  Note multiples of 15 will fire both Duck and Goose.
                    work.Append("Goose");
                if (work.Length == 0)                           //Check to see if the string is empty.
                    work.Append(index.ToString());              //If so, append the number to the string.
                if (index < count)
                    work.Append(Environment.NewLine);           //New line until the last pass.
                sb.Append(work);                                //Write this pass to the output string.
                work.Clear();                                   //Clear the wrok string to prepare the next pass.
            }
            return sb.ToString();                               //return the final string.
        }
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}
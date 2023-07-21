using System.Diagnostics.Metrics;

namespace Lab03_Review
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Please enter in 3 numbers:");
            string input = Console.ReadLine();
            /*string chal2 = Console.ReadLine();*/
            Challenge1(input);
            Challenge2();
             /*int result = Challenge1(input);
            Console.WriteLine("The result is: " + result);*/
             string inputTwo = Console.ReadLine();
            Challenge3();
            Challenge4();
            Challenge5();
            Challenge6();
            Challenge7();
            Challenge8();
            Challenege9(inputTwo);        }


        // this method takes a string input with numbers thats seperated by spaces-
        //if the person enters in 3 numbers it will calcute thier product. If they enter less than 3 than it will return 0
        public static int Challenge1(string input)
        {
            //Initialize the product variable to 1
            int product = 1;


            // Split the input string by spaces to get an array of numbers
            string[] inputArray = input.Split(" ");

            if (inputArray.Length < 3)
            {
                Console.WriteLine(" You entered in less than 3 numbers");
                product = 0;
                return product;
            }

            // iterating over the first 3 numbers in the input array
            for (int i = 0; i < inputArray.Length; i++)
            {
                // If the loop index is greater than or equal to the length of the input array, exit the loop
                if (i >= inputArray.Length)
                {
                    break;
                }
                // Declare a variable 'number' to store the parsed integer value
                // out keyword refers to a param is passed by reference.
                if (int.TryParse(inputArray[i], out int number))
                {
                    // If parsing is successful, multiply the product by the parsed number
                    product *= number;
                }
                else
                {
                    //if parsing isnt successful, mulitple the product by 1
                    product *= 1;
                }
            }
            Console.WriteLine($"The product of 3 numbers is: {product}");
            return product;


        }


        //The Challenge2 method prompts the user to enter a number between 2 and 10.
        //It then asks the user to enter a series of numbers equal to the previously entered number.
        //The code calculates the sum of these numbers, excluding any negative values.
        //Finally, it calculates the average of the entered numbers, prints it to the console, and returns the average as the result.
        public static decimal Challenge2()
        {
            Console.Write("Please enter a number between 2-10:");

            int length = Convert.ToInt32(Console.ReadLine());
            while (length < 2 || length > 10)
            {
                Console.Write("Please enter a number between 2-10:");
                length = Convert.ToInt32(Console.ReadLine());
            }

            decimal[] range = new decimal[length];
            decimal sum = 0;
            for (int i = 0; i < range.Length; i++)
            {
                Console.Write($"{i + 1} of {range.Length} - Enter a number: ");
                decimal userInput = 0;
                bool validInput = decimal.TryParse(Console.ReadLine(), out userInput);

                if (validInput)
                {
                    sum += userInput;
                }
                else
                {
                    sum += 0;
                    Console.WriteLine("Input is not a valid number. Assigned default value: 0");
                }
            }

            decimal average = sum / Convert.ToDecimal(range.Length);
            decimal remainder = sum % Convert.ToDecimal(range.Length);

            Console.WriteLine($"The average of these {range.Length} numbers is: {average}");
            Console.WriteLine($"The remainder of the sum after division by {range.Length} is: {remainder}");
            return average;

            /*{

                Console.Write("Please enter a number between 2-10:");

                int length = Convert.ToInt32(Console.ReadLine());
                while (length < 2 || length > 10)
                {
                    Console.Write("Please enter a number between 2-10:");
                    length = Convert.ToInt32(Console.ReadLine());
                }
                decimal[] range = new decimal[length];
                decimal sum = 0;
                for (int i = 0; i < range.Length; i++)
                {
                    Console.Write($"{i + 1} of {range.Length} - Enter a number: ");
                    decimal userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput >= 0)
                    {
                        sum += userInput;
                    }
                    else
                    {
                        sum += 0;
                        Console.WriteLine("Input is not a number. Assigned default value: 0");
                    }
                }
                decimal average = sum / Convert.ToDecimal(range.Length);
                Console.WriteLine($"The average of these {range.Length} numbers is: {average}");
                return average;



            }*/

        }
        public static decimal Challenge_2_Test(int lengthInput, decimal[] range)
        {
            decimal sum = 0;
            for (int i = 0; i < range.Length; i++)
            {
                if (range[i] >= 0)
                {
                    sum += range[i];
                }
                else
                {
                    return 0;
                }
            }
            decimal average = sum / range.Length;
            return average;
        }



        public static void Challenge3()
        {
            Console.WriteLine("Here is your design");

            Console.WriteLine("      *");
            Console.WriteLine("     ***");
            Console.WriteLine("    *****");
            Console.WriteLine("   *******");
            Console.WriteLine("  *********");
            Console.WriteLine("   *******");
            Console.WriteLine("    *****");
            Console.WriteLine("     ***");
            Console.WriteLine("      *");
        }


        //The Challenge4 method prompts the user to enter a number between 1 and 10.
        //It then asks the user to enter a series of numbers equal to the previously entered number.
        //The code finds the most frequently occurring number in the entered series.
        //Finally, it prints the most frequent number to the console and returns it as the result.
        public static int Challenge4()
        {

            Console.Write("Enter a number between 1 and 10: ");

            int length = Convert.ToInt32(Console.ReadLine());

            while (length < 1 || length > 10)
            {
                Console.Write(" enter a number between 1 and 10:");
                length = Convert.ToInt32(Console.ReadLine());
            }

            int[] numbers = new int[length];
            int userInput;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1} of {numbers.Length} - Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                numbers[i] = userInput;
            }

            int mostFrequentNum = numbers[0];
            int mostFrequentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }

                if (count > mostFrequentCount)
                {
                    mostFrequentCount = count;
                    mostFrequentNum = numbers[i];
                }
            }

            Console.WriteLine($"Output: {mostFrequentNum}");
            return mostFrequentNum;
        }



        public static int Challenge_4_Test(int[] numbers)
        {


            int mostFrequentNum = numbers[0];
            int mostFrequentCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }

                if (count > mostFrequentCount)
                {
                    mostFrequentCount = count;
                    mostFrequentNum = numbers[i];
                }
            }

            return mostFrequentNum;
        }


        //The Challenge5 method prompts the user to enter a number between 1 and 10.
        //It then asks the user to enter a series of numbers equal to the previously entered number.
        //The code finds the highest number from the entered series using the Max method of the numbers array.
        //Finally, it prints the highest number to the console and returns it as the result.
        public static int Challenge5()
        {
            Console.WriteLine("Enter in a number between 1- 10");

            int Length = Convert.ToInt32(Console.ReadLine());

            while (Length < 1 || Length > 10)
            {
                Console.Write("Please enter a number between 1 and 10:");
                Length = Convert.ToInt32(Console.ReadLine());
            }

            int[] numbers = new int[Length];
            int userInput;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1} of {numbers.Length} - Enter a number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                numbers[i] = userInput;
            }

            int highestNum = numbers.Max();// im using the max method to return the maximum value in the numbers array

            Console.WriteLine($"The highest number was {highestNum}");
            return highestNum;
        }

        public static int Challenge_5_Test(int[] numbers)
        {
            int highestNum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (highestNum < numbers[i])
                {
                    highestNum = numbers[i];
                }
            }

            Console.WriteLine($"The highest number was {highestNum}");
            return highestNum;
        }

       // Overall, the code allows the user to enter a word and appends it to a file.
        public static void Challenge6()
        {

            
            //C:\Users\KDots\OneDrive\Documents\GitHub\Lab03-Review\words.txt
            Console.Write("Please enter a word: ");
            string? word = Console.ReadLine();
            //string filePath = "/Users/krisdotson/projects/Lab03-Review/Lab03-Review/words.txt";
            string filePath = "C:\\Users\\KDots\\OneDrive\\Documents\\GitHub\\Lab03-Review\\words.txt";

            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(word);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while writing to the file: " + e.Message);
            }
        }

        //The Challenge7 method reads the contents of a file located at the specified filePath. It attempts to read all the lines from the file using File.ReadAllLines method and stores them in a string array lines.
        //If successful, it then prints the contents of the file to the console by iterating through each line and displaying it
        //the code reads the contents of a file and displays them on the console.
        public static void Challenge7()
        {
            string filePath = "C:\\Users\\KDots\\OneDrive\\Documents\\GitHub\\Lab03-Review\\words.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("File Contents:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }

        //Overall, the code removes a word from the file's content and rewrites the modified content back to the file.

        public static void Challenge8()
        {
            string filePath = "C:\\Users\\KDots\\OneDrive\\Documents\\GitHub\\Lab03-Review\\words.txt";

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Remove one of the words (e.g., the first word)
                if (lines.Length > 0)
                {
                    List<string> wordList = new List<string>(lines);
                    wordList.RemoveAt(0);
                    lines = wordList.ToArray();
                }

                // Rewrite the modified content back to the file
                File.WriteAllLines(filePath, lines);

                Console.WriteLine("Word removed and file rewritten successfully.");
            }
            catch (IOException e)
            {
                Console.WriteLine("An has error occurred while removing and rewriting the word: " + e.Message);
            }
        }

        // the code splits an input string into individual words, calculates the length of each word, and returns an array where each element contains the original word followed by its length.
        public static string[] Challenege9(string input)
        {
            string[] words = input.Split(" ");
            string[] result = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int length = word.Length;
                result[i] = $"{word}: {length}";
            }

            return result;
        }
    }


}



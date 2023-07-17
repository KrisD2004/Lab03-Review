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

        public static decimal Challenge2()
        {
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



            }

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



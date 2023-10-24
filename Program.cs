using System;

namespace AverageOfFiveNumbers
{
    class Program
    {
        private static double CalculateAverage(int[] numbers)
        {
            double totalSum = 0;
            foreach (int number in numbers)
            {
                totalSum += number;
            }

            return totalSum / numbers.Length;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter {OrdinalSuffix(i + 1)} number: ");
                string input = Console.ReadLine();

                // Validate the input.
                if (!int.TryParse(input, out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--;
                    continue;
                }
            }

            double average = CalculateAverage(numbers);

            // Display the result.
            Console.WriteLine("The average of five numbers is: " + average);

            // Keep prompting the user to choose only Y or N when asking if they want to continue the program.
            string question;
            do
            {
                Console.WriteLine("Do you want to continue Y/N?");
                question = Console.ReadLine();

                // Validate the input.
                if (!question.ToUpper().Equals("Y") && !question.ToUpper().Equals("N"))
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }
            } while (!question.ToUpper().Equals("Y") && !question.ToUpper().Equals("N"));

            // If the user chooses to continue, repeat the process.
            if (question.ToUpper().Equals("Y"))
            {
                Main(null);
            }
            else
            {
                Console.WriteLine("THANK YOU FOR USING:)");
                Console.ReadKey();
            }
        }

        private static string OrdinalSuffix(int number)
        {
 
                    switch (number % 10)
                    {
                        case 1:
                            return "1st";
                        case 2:
                            return "2nd";
                        case 3:
                            return "3rd";
                        case 4:
                            return "4th";
                        default:
                            return "5th";
                    }
            }
        }
    }

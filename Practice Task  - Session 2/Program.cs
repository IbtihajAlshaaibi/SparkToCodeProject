namespace Practice_Task____Session_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Task 1 - Countdown Timer
            //Console.Write("Enter the starting number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = number; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Liftoff!");


            //////////////////////////////////////////////////////////////////////////

            // Task 2 - Sum of Numbers 1 to N

            //Console.Write("Enter a positive whole number: ");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("The sum is: " + sum);

            //////////////////////////////////////////////////////////////////////////

            //Task 3 - Multiplication Table

            //int number;

            //Console.Write("Enter a number: ");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(number + " x " + i + " = " + (number * i));
            //}

            //////////////////////////////////////////////////////////////////////////

            // Task 4 - Password Retry

            //string password = "Spark2026";
            //string userInput = "";

            //while (userInput != password)
            //{
            //    Console.Write("Enter the password: ");
            //    userInput = Console.ReadLine();

            //    if (userInput != password)
            //    {
            //        Console.WriteLine("Incorrect password please try again");
            //    }
            //}

            //Console.WriteLine("Access Granted");

            //////////////////////////////////////////////////////////////////////////

            // Task 5 - Number Guessing Game

            //int secretNumber = 42;
            //int userGuess;
            //int attempts = 0;

            //do
            //{
            //    Console.Write("Guess the secret number: ");
            //    userGuess = int.Parse(Console.ReadLine());

            //    attempts++;

            //    if (userGuess > secretNumber)
            //    {
            //        Console.WriteLine("Too high");
            //    }
            //    else if (userGuess < secretNumber)
            //    {
            //        Console.WriteLine("Too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Correct!");
            //    }

            //} while (userGuess != secretNumber);

            //Console.WriteLine("Number of attempts: " + attempts);

            /////////////////////////////////////////////////////////////////////////

            // Task 6 - Safe Division Calculator

            //try
            //{
            //    Console.Write("Enter the first number: ");
            //    int number1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number: ");
            //    int number2 = int.Parse(Console.ReadLine());

            //    int result = number1 / number2;

            //    Console.WriteLine("The result is: " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You cannot divide by zero");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number");

            //}

            //////////////////////////////////////////////////////////////////////////

            // Task 7 - Repeating Menu with Exit Option

            //bool exitDecision = false;
            //int userChoice;

            //while (exitDecision == false)
            //{
            //    Console.WriteLine(" MENU ");
            //    Console.WriteLine("1. Say Hello");
            //    Console.WriteLine("2. Show Current Time-of-day Greeting");
            //    Console.WriteLine("3. Exit");

            //    try
            //    {
            //        Console.Write("Enter your choice: ");
            //        userChoice = int.Parse(Console.ReadLine());

            //        switch (userChoice)
            //        {
            //            case 1:
            //                Console.WriteLine("Hello..");
            //                break;

            //            case 2:
            //                Console.WriteLine("Good Morning..");
            //                break;

            //            case 3:
            //                Console.WriteLine("Exiting the program...");
            //                exitDecision = true;
            //                break;

            //            default:
            //                Console.WriteLine("Invalid choice..");
            //                break;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number.");
            //    }

            //    Console.WriteLine();
            //}

            //////////////////////////////////////////////////////////////////////////

            // Task 8 - Sum of Even Numbers Only

            int number;
            int sum = 0;

            Console.Write("Enter a positive whole number: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("The sum of even numbers is: " + sum);


        }
    }
}

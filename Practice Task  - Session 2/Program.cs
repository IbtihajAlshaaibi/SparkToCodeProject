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

            //int number;
            //int sum = 0;

            //Console.Write("Enter a positive whole number: ");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum = sum + i;
            //    }
            //}

            //Console.WriteLine("The sum of even numbers is: " + sum);

            //////////////////////////////////////////////////////////////////////////

            // Task 9 - Validated Positive Number Input

            //int number = 0;
            //bool valid = false;

            //do
            //{
            //    try
            //    {
            //        Console.Write("Enter a positive whole number: ");
            //        number = int.Parse(Console.ReadLine());

            //        if (number <= 0)
            //        {
            //            Console.WriteLine("Please enter a number greater than 0.");
            //            valid = false;
            //        }
            //        else
            //        {
            //            valid = true;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid whole number.");
            //        valid = false;
            //    }

            //} while (valid == false);

            //int sum = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    sum = sum + i;
            //}

            //Console.WriteLine("The sum is: " + sum);



            //////////////////////////////////////////////////////////////////////////

            //Task 10 - Simple ATM Simulation

            int correctPin = 1234;
            int pin;
            int attempts = 0;
            bool access = false;

            while (attempts < 3)
            {
                try
                {
                    Console.Write("Enter PIN: ");
                    pin = int.Parse(Console.ReadLine());

                    if (pin == correctPin)
                    {
                        access = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong PIN");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid PIN");
                }

                attempts++;
            }

            if (access == false)
            {
                Console.WriteLine("Card Blocked");
                return;
            }

            double balance = 100.000;
            int choice;

            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                try
                {
                    Console.Write("Choose option: ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Enter deposit amount: ");
                            double deposit = double.Parse(Console.ReadLine());

                            if (deposit <= 0)
                            {
                                Console.WriteLine("Invalid amount");
                            }
                            else
                            {
                                balance += deposit;
                                Console.WriteLine("Deposit successful");
                                Console.WriteLine("Balance: " + balance);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid amount");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.Write("Enter withdraw amount: ");
                            double withdraw = double.Parse(Console.ReadLine());

                            if (withdraw <= 0)
                            {
                                Console.WriteLine("Invalid amount");
                            }
                            else if (withdraw > balance)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else
                            {
                                balance -= withdraw;
                                Console.WriteLine("Withdraw successful");
                                Console.WriteLine("Balance: " + balance);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid amount");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Balance: " + balance);
                        break;

                    case 4:
                        Console.WriteLine("Goodbye");
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }


        }
    }
}

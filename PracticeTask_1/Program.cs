namespace PracticeTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personal Info Card
            //string name = "Ibtihaj";
            //int age = 24;
            //double height = 1.59;
            //bool isStudent = false;

            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Height: " + height);
            //Console.WriteLine("Student: " + isStudent);

            ///////////////////////////////////////////////////////////////////////////


            //Task 2 - Rectangle Calculator
            //Console.Write("Enter the length of the rectangle: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.Write("Enter the width of the rectangle: ");
            //double width = double.Parse(Console.ReadLine());

            //double area = length * width;
            //double perimeter = 2 * (length + width);

            //Console.WriteLine("Area = " + area);
            //Console.WriteLine("Perimeter = " + perimeter);

            ///////////////////////////////////////////////////////////////////////////

            //Task 3 - Even or Odd Checker
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}

            ///////////////////////////////////////////////////////////////////////////

            //Task 4 - Voting Eligibility
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Do you have a valid national ID? (yes/no): ");
            //string answer = Console.ReadLine();

            //if (age >= 18 && answer == "yes")
            //{
            //    Console.WriteLine("You are eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote");
            //}

            ///////////////////////////////////////////////////////////////////////////

            //Task 5 - Grade Letter Lookup

            //Console.Write("Enter your grade (A, B, C, D, F): ");
            //char grade = char.Parse(Console.ReadLine());

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;

            //    case 'D':
            //        Console.WriteLine("Pass");
            //        break;

            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}

            ///////////////////////////////////////////////////////////////////////////

            //Task 6 - Temperature Converter

            //Console.Write("Enter the temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);

            //if (celsius < 10)
            //{
            //    Console.WriteLine("Weather: Cold");
            //}
            //else if (celsius <= 30)
            //{
            //    Console.WriteLine("Weather: Mild");
            //}
            //else
            //{
            //    Console.WriteLine("Weather: Hot");
            //}

            ///////////////////////////////////////////////////////////////////////////

            //Task 7 - Movie Ticket Pricing

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 12)
            //{
            //    Console.WriteLine("Category: Child");
            //    Console.WriteLine("Ticket Price: 2.000 OMR");
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    Console.WriteLine("Category: Adult");
            //    Console.WriteLine("Ticket Price: 5.000 OMR");
            //}
            //else
            //{
            //    Console.WriteLine("Category: Senior");
            //    Console.WriteLine("Ticket Price: 3.000 OMR");
            //}

            ///////////////////////////////////////////////////////////////////////////

            // Task 8 - Restaurant Bill with Membership Discount

            //Console.Write("Enter the total bill amount: ");
            //double bill = double.Parse(Console.ReadLine());

            //Console.Write("Are you a loyalty member? (yes/no): ");
            //string answer = Console.ReadLine();

            //bool isMember = (answer == "yes");

            //double discount = 0;
            //double finalAmount = bill;

            //if (bill > 20 && isMember)
            //{
            //    discount = bill * 0.15;
            //    finalAmount = bill - discount;
            //}

            //Console.WriteLine("Original Bill = " + bill + " OMR");
            //Console.WriteLine("Discount = " + discount + " OMR");
            //Console.WriteLine("Final Amount = " + finalAmount + " OMR");

            ///////////////////////////////////////////////////////////////////////////

            // Task 9 - Day Name Finder

            Console.Write("Enter a day number (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }


        }
    }
}

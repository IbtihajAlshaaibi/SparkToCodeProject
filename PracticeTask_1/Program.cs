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

            //Console.Write("Enter a day number (1-7): ");
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;

            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;

            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;

            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;

            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;
            //

            ///////////////////////////////////////////////////////////////////////////

            //Task 10 - Mini Calculator

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /, %): ");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result = " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result = " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;

                case '%':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result = " + (num1 % num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;


                    ///////////////////////////////////////////////////////////////////////////

                    // Task 11 - Loan Eligibility System

                    //Console.Write("Enter your age: ");
                    //int age = int.Parse(Console.ReadLine());

                    //Console.Write("Enter your monthly income : ");
                    //double income = double.Parse(Console.ReadLine());

                    //Console.Write("Do you have an existing loan? (yes/no): ");
                    //string answer = Console.ReadLine();

                    //bool hasLoan = (answer == "yes");

                    //if (age >= 21 && age <= 60 && income >= 400 && !hasLoan)
                    //{
                    //    Console.WriteLine("You are eligible for the personal loan");
                    //}
                    //else
                    //{
                    //    if (age < 21 || age > 60)
                    //    {
                    //        Console.WriteLine("Not eligible: Age out of range");
                    //    }
                    //    else if (income < 400)
                    //    {
                    //        Console.WriteLine("Not eligible: Income is too low");
                    //    }
                    //    else if (hasLoan)
                    //    {
                    //        Console.WriteLine("Not eligible: You already have an existing loan");
                    //    }


                    //}

                    ///////////////////////////////////////////////////////////////////////////

                    // Task 12 - Shipping Cost Calculator

                    //Console.Write("Enter region code (A, B, C): ");
                    //char region = char.Parse(Console.ReadLine());

                    //Console.Write("Enter package weight (kg): ");
                    //double weight = double.Parse(Console.ReadLine());

                    //double baseCost = 0;
                    //double extraCharge = 0;
                    //double totalCost = 0;

                    //switch (region)
                    //{
                    //    case 'A':
                    //        baseCost = 1.000;

                    //        if (weight > 10)
                    //            extraCharge = 5.000;
                    //        else if (weight > 5)
                    //            extraCharge = 2.000;

                    //        totalCost = baseCost + extraCharge;

                    //        Console.WriteLine("Base Cost = " + baseCost + " OMR");
                    //        Console.WriteLine("Extra Charge = " + extraCharge + " OMR");
                    //        Console.WriteLine("Total Shipping Cost = " + totalCost + " OMR");
                    //        break;

                    //    case 'B':
                    //        baseCost = 3.000;

                    //        if (weight > 10)
                    //            extraCharge = 5.000;
                    //        else if (weight > 5)
                    //            extraCharge = 2.000;

                    //        totalCost = baseCost + extraCharge;

                    //        Console.WriteLine("Base Cost = " + baseCost + " OMR");
                    //        Console.WriteLine("Extra Charge = " + extraCharge + " OMR");
                    //        Console.WriteLine("Total Shipping Cost = " + totalCost + " OMR");
                    //        break;

                    //    case 'C':
                    //        baseCost = 7.000;

                    //        if (weight > 10)
                    //            extraCharge = 5.000;
                    //        else if (weight > 5)
                    //            extraCharge = 2.000;

                    //        totalCost = baseCost + extraCharge;

                    //        Console.WriteLine("Base Cost = " + baseCost + " OMR");
                    //        Console.WriteLine("Extra Charge = " + extraCharge + " OMR");
                    //        Console.WriteLine("Total Shipping Cost = " + totalCost + " OMR");
                    //        break;

                    //    default:
                    //        Console.WriteLine("Invalid region");
                    //        break;
                    //}

                    ///////////////////////////////////////////////////////////////////////////

                    // Task 13 - Triangle Type Classifier

                    //Console.Write("Enter the first side: ");
                    //double side1 = double.Parse(Console.ReadLine());

                    //Console.Write("Enter the second side: ");
                    //double side2 = double.Parse(Console.ReadLine());

                    //Console.Write("Enter the third side: ");
                    //double side3 = double.Parse(Console.ReadLine());

                    //if (side1 + side2 > side3 &&
                    //    side1 + side3 > side2 &&
                    //    side2 + side3 > side1)
                    //{
                    //    if (side1 == side2 && side2 == side3)
                    //    {
                    //        Console.WriteLine("Triangle Type: Equilateral");
                    //    }
                    //    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    //    {
                    //        Console.WriteLine("Triangle Type: Isosceles");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Triangle Type: Scalene");
                    //    }
                    //}
                    //else
                    //{
                    //    Console.WriteLine("The sides do not form a valid triangle");
                    //}

                    ///////////////////////////////////////////////////////////////////////////

                    // Task 14 - Online Store Checkout

                    //Console.Write("Enter product code (1, 2, 3): ");
                    //int productCode = int.Parse(Console.ReadLine());

                    //Console.Write("Enter quantity: ");
                    //int quantity = int.Parse(Console.ReadLine());

                    //Console.Write("Do you have a discount coupon? (yes/no): ");
                    //string answer = Console.ReadLine();

                    //bool hasCoupon = (answer == "yes");

                    //double unitPrice = 0;
                    //double subtotal = 0;
                    //double discount = 0;
                    //double tax = 0;
                    //double finalTotal = 0;

                    //switch (productCode)
                    //{
                    //    case 1:
                    //        unitPrice = 8.500;
                    //        break;

                    //    case 2:
                    //        unitPrice = 12.000;
                    //        break;

                    //    case 3:
                    //        unitPrice = 5.000;
                    //        break;

                    //    default:
                    //        Console.WriteLine("Invalid product code");
                    //        return;
                    //}

                    //subtotal = unitPrice * quantity;

                    //if (hasCoupon && subtotal > 20)
                    //{
                    //    discount = subtotal * 0.10;
                    //}

                    //tax = (subtotal - discount) * 0.05;
                    //finalTotal = (subtotal - discount) + tax;

                    //Console.WriteLine("Subtotal = " + subtotal + " OMR");
                    //Console.WriteLine("Discount = " + discount + " OMR");
                    //Console.WriteLine("Tax = " + tax + " OMR");
                    //Console.WriteLine("Final Total = " + finalTotal + " OMR");


                    ///////////////////////////////////////////////////////////////////////////

                    //Task 15 - University Admission Decision

                    Console.Write("Enter program type (S for Science, A for Arts): ");
                    char program = char.Parse(Console.ReadLine());

                    Console.Write("Enter your GPA (out of 4.0): ");
                    double gpa = double.Parse(Console.ReadLine());

                    Console.Write("Enter your entrance exam score (out of 100): ");
                    int examScore = int.Parse(Console.ReadLine());

                    Console.Write("Do you have an extracurricular achievement? (yes/no): ");
                    string answer = Console.ReadLine();

                    bool hasAchievement = (answer == "yes");

                    switch (program)
                    {
                        case 'S':
                            if (gpa >= 3.0 && examScore >= 75)
                            {
                                Console.WriteLine("Program: Science");
                                Console.WriteLine("Result: Admitted");
                            }
                            else if (hasAchievement)
                            {
                                Console.WriteLine("Program: Science");
                                Console.WriteLine("Result: Conditionally Admitted");
                            }
                            else
                            {
                                Console.WriteLine("Program: Science");
                                Console.WriteLine("Result: Not Admitted");
                            }
                            break;

                        case 'A':
                            if (gpa >= 2.5 && examScore >= 60)
                            {
                                Console.WriteLine("Program: Arts");
                                Console.WriteLine("Result: Admitted");
                            }
                            else if (hasAchievement)
                            {
                                Console.WriteLine("Program: Arts");
                                Console.WriteLine("Result: Conditionally Admitted");
                            }
                            else
                            {
                                Console.WriteLine("Program: Arts");
                                Console.WriteLine("Result: Not Admitted");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid program type");
                            break;


                    }
        }
}

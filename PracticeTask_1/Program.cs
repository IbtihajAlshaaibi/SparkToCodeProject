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
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Do you have a valid national ID? (yes/no): ");
            string answer = Console.ReadLine();
            
            if (age >= 18 && answer == "yes")
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
        }


    }
    }
}

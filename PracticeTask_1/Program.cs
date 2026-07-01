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
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);

            ///////////////////////////////////////////////////////////////////////////

            //Task 3 - Even or Odd Checker
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }


    }
    }
}

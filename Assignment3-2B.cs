//find max and min element in an array

namespace Assignment3_2B
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //declaring a variable to take array size from user
            int size;

            // user input
            Console.Write("Enter the array size: ");

            //validating size of array
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid Input!! Please Enter A Positive Integer: ");

            }

            //declaring array 
            int[] numbers = new int[size];

            //user input of elements
            Console.Write("Enter the array elements: ");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");

                //validation of  elements
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                    Console.Write($"Element {i + 1}: ");
                }
            }
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"\nThe Largest element in the array is: {max}");
            Console.WriteLine($"The Smallest element in the array is: {min}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
namespace Assignment3_3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //separate odd and even integers in separate arrays.

            //declaring a variable
            int size;

            //getting user input for array size
            Console.Write("Enter number of element you need in array: ");

            //Validating
            while(!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Invalid Inuput!! Enter a Positive number: ");
            }

            //declaring variables for array
            int[] numbers = new int[size];
            int i;

            //loop to add the elements in the loop
            for (i = 0; i < size; i++)
            {
                Console.Write($"Enter Array Element{i + 1}: ");

                //validating array elements
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid Input!! Enter a positive number. ");
                    Console.Write($"Enter Array Element{i + 1}: ");
                }
            }

            //declaring array for saving even and odd numbers separately
            int[] oddNumbers = new int[numbers.Length];
            int[] evenNumbers = new int[numbers.Length];

            int evenCount = 0;  
            int oddCount = 0;

            //to check whether the numbers are even or not
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNumbers[evenCount] = num;
                    evenCount++;
                }
                else
                {
                    oddNumbers[oddCount] = num;
                    oddCount++;
                }
            }

            // Displaying results
            Console.WriteLine("\nEven Numbers in the array:");
            for (i = 0; i < evenCount; i++)
            {
                Console.WriteLine($"{evenNumbers[i]} ");
            }

            Console.WriteLine("\n\nOdd Numbers in the array:");
            for ( i = 0; i < oddCount; i++)
            {
                Console.WriteLine($"{oddNumbers[i]} ");
            }



            Console.WriteLine("Press any key to Exit...");
            Console.ReadLine();
        }
    }
}
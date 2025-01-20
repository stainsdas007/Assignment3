namespace Assignment3_1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<int> checkedNum = new List<int>();

            //  user to enter the size of the array
            Console.Write("Enter the number of elements in the array: ");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the array size:");
            }

            // Initialize the array
            int[] array = new int[length];

            // Collect array elements from the user with validation
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter  element  {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    Console.Write($"Enter integer value for element {i + 1}: ");
                }
            }

            // Logic to count duplicate elements
            for (int i = 0; i < length; i++)
            {
                if (checkedNum.Contains(array[i]))
                {
                    continue;
                }

                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        break; // Skip duplicates to avoid multiple counting
                    }
                }

                checkedNum.Add(array[i]);
            }

            // Output the number of duplicates
            Console.WriteLine("Number of duplicates: " + count);
        }
    }
}


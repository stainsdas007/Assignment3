namespace Assignment3_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 7, 9 };
            //int size = array.Length;

            Console.Write("Enter the number of elements in the array: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the array size:");
            }

            // Initialize the array
            int[] array = new int[size];

            // Collect array elements from the user with validation
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter  element  {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                    Console.Write($"Enter integer value for element {i + 1}: ");
                }
            }

            // Corrected sorting logic using indices
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] < array[j])
                    {
                        // Swap the elements
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            // Output the sorted array
            Console.WriteLine("Array elements in descending order:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}

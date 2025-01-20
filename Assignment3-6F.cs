namespace Assignment3_6F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delete an element at desired position from an array. 

            // Declaring a Sample array
            //int[] array = { 1, 3, 5, 7, 9, 10 };


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


            // Display the original array
            Console.WriteLine("Original Array:");
            DisplayArray(array);

            // Get the position to delete
            Console.Write("Enter the position (0-based index) of the element to delete: ");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 0 || position >= array.Length)
            {
                Console.WriteLine("Invalid input! Please enter a valid index.");
            }

            // Delete the element at the given position
            array = DeleteElementAtPosition(array, position);

            // Display the updated array
            Console.WriteLine("\nArray after deletion:");
            DisplayArray(array);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        // Method to delete an element at a given position
        static int[] DeleteElementAtPosition(int[] arr, int position)
        {
            // Create a new array of size one less than the original array
            int[] newArr = new int[arr.Length - 1];

            // Copy all elements before the given position
            for (int i = 0; i < position; i++)
            {
                newArr[i] = arr[i];
            }

            // Copy all elements after the given position
            for (int i = position + 1; i < arr.Length; i++)
            {
                newArr[i - 1] = arr[i];
            }

            return newArr;
        }

        // Method to display the array
        static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
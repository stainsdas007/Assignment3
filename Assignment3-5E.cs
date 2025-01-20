// insert New value in the array (sorted list). 
namespace Assignment3_5E
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // declaring array
            int[] sortedArray = { 6, 2, 3,8, 9, 10 };

            // Getting user input of the new value 
            Console.Write("Enter a value to insert into the sorted array: ");
            int newValue;
            while (!int.TryParse(Console.ReadLine(), out newValue))
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
            }

            // Find the correct position to insert the new value
            int[] newArray = InsertSorted(sortedArray, newValue);

            // Display the new array
            Console.WriteLine("\nArray after insertion:");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        static int[] InsertSorted(int[] sortedArray, int newValue)
        {
            // Create a new array with one extra slot for the new value
            int[] newArray = new int[sortedArray.Length + 1];

            // Find the correct position for the new value
            int i = 0;
            while (i < sortedArray.Length && sortedArray[i] < newValue)
            {
                newArray[i] = sortedArray[i];
                i++;
            }

            // Insert the new value at the correct position
            newArray[i] = newValue;

            // Copy the remaining elements
            while (i < sortedArray.Length)
            {
                newArray[i + 1] = sortedArray[i];
                i++;
            }

            return newArray;
        }
    }
}
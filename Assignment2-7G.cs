namespace Assignment2_7G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int customerId;
            string customerName;
            double unitsConsumed, totalAmount;

            // Taking user input
            Console.Write("Enter Customer ID: ");
            while (!int.TryParse(Console.ReadLine(), out customerId))
            {
                Console.Write("Invalid input! Please enter a valid Customer ID: ");
            }

            Console.Write("Enter Customer Name: ");
            customerName = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            while (!double.TryParse(Console.ReadLine(), out unitsConsumed) || unitsConsumed < 0)
            {
                Console.Write("Invalid input! Please enter a valid number for units consumed: ");
            }

            // Calculate the total amount based on the units consumed
            if (unitsConsumed <= 199)
            {
                totalAmount = unitsConsumed * 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                totalAmount = unitsConsumed * 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                totalAmount = unitsConsumed * 1.80;
            }
            else
            {
                totalAmount = unitsConsumed * 2.00;
            }

            // Display the result
            Console.WriteLine("\n===== Electricity Bill =====");
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Units Consumed: {unitsConsumed}");
            Console.WriteLine($"Total Amount to Pay: Rs{totalAmount:F2}");
        }
    }
}
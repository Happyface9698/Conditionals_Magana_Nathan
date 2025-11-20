namespace Conditionals_Magana_Nathan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:"); // Prompt user for input

            string isNumber = Console.ReadLine(); // Read user input

            int number;
            bool isParsed = int.TryParse(isNumber, out number); // Try to parse input to int

            bool positive = isParsed && number > 0; // Check if the number is positive only if parsing succeeded

            if (positive)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is not positive.");
            }

        }
    }
}


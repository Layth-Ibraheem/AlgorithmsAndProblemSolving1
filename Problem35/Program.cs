namespace Problem35
{
    internal class Program
    {
        // Write a program to ask the user to enter: Pennies, Nickels, Dimes, Quarters, Dollars
        // then calculate the total pennies and the total dollars
        // Penny = 1
        // Nickle = 5
        // Dime = 10
        // Quarters = 25
        // Dollars = 100
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int CalculateTotalPennies(int pennies, int nickles, int dimes, int quarters, int dollars)
        {
            return (pennies) + (nickles * 5) + (dimes * 10) + (quarters * 25) + (dollars * 100);
        }
        static float CalculateTotalDollars(int totalPennies)
        {
            return (float)totalPennies / 100;
        }
        static void Main(string[] args)
        {
            int pennies = ReadNumber("Please enter the number of pennies: ");
            int nickles = ReadNumber("Please enter the number of nickles: ");
            int dimes = ReadNumber("Please enter the number of dimes: ");
            int quarters = ReadNumber("Please enter the number of quarters: ");
            int dollars = ReadNumber("Please enter the number of dollars: ");
            int totalPennies = CalculateTotalPennies(pennies, nickles, dimes, quarters, dollars);
            Console.WriteLine($"Total pennies: {totalPennies}");
            Console.WriteLine($"Total dollars: {CalculateTotalDollars(totalPennies)}");

        }
    }
}

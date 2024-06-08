namespace Problem34
{
    internal class Program
    {
        // Write a program to ask the user to enter the Total Sales then calculate the commision
        // Total Sales > 1M => Percentage is 1%
        // Total Sales between 500K and 1M => Percentage is 2%
        // Total Sales between 100K and 500K => Percentage is 3%
        // Total Sales between 50K and 100K => Percentage is 5%
        // Otherwise => Percentage is 0%

        static float ReadNumber(string message)
        {
            Console.WriteLine(message);
            float result = float.Parse(Console.ReadLine() ?? "0");
            return result;
        }

        static int GetPercenteg(float totalSales)
        {
            if (totalSales >= 1000000)
                return 1;
            if (totalSales >= 500000 && totalSales < 1000000)
                return 2;
            if (totalSales >= 100000 && totalSales < 500000)
                return 3;
            if (totalSales >= 50000 && totalSales < 100000)
                return 5;

            return 0;
        }
        static float CalculatePercenteg(float totalSales, int percentegNumber)
        {
            return ((float)percentegNumber / 100) * totalSales;
        }
        static void Main(string[] args)
        {
            float totalSales = ReadNumber("Please enter the total sales: ");
            Console.WriteLine($"Total sales: {totalSales}, Commision: {CalculatePercenteg(totalSales, GetPercenteg(totalSales))}");
        }
    }
}

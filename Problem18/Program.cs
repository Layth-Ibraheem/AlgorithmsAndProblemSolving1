namespace Problem18
{
    internal class Program
    {
        // Write a program to calculate circle area then print it

        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateCircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static void Main(string[] args)
        {
            double r = ReadNumber("Please enter r: ");
            Console.WriteLine($"The circle area that has r = {r} is: {CalculateCircleArea(r)}");
        }
    }
}

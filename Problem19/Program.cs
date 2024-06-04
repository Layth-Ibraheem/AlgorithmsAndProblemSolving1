namespace Problem19
{
    internal class Program
    {
        // Write a program that caculates the circle area based on the diameter
        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateCircleArea(double Diameter)
        {
            return Math.PI * Math.Pow(Diameter, 2) / 4;
        }
        static void Main(string[] args)
        {
            double Diameter = ReadNumber("Please enter Diameter: ");
            Console.WriteLine($"The circle area that has Diameter = {Diameter} is: {CalculateCircleArea(Diameter)}");
        }
    }
}

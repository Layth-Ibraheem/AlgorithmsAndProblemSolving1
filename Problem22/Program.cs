namespace Problem22
{
    internal class Program
    {
        // Write a program to calculate circele area inscribed in isosceles triangle

        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateCircleAreaIInscribedInIsoscelesTriangle(double a, double b)
        {
            double area = Math.PI * Math.Pow(b, 2) / 4 * ((2 * a - b) / (2 * a + b));
            return area;
        }
        static void Main(string[] args)
        {
            double a = ReadNumber("Please enter a: ");
            double b = ReadNumber("Please enter b: ");

            Console.WriteLine($"The circle area that has a = {a} and b = {b} is: {CalculateCircleAreaIInscribedInIsoscelesTriangle(a, b)}");
        }
    }
}

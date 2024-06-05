namespace Problem23
{
    internal class Program
    {
        // Write a program to calculate circle area described around an arbitrary triangle

        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateCircleAreaDescribedAroundArbitraryTriangle(double a, double b, double c)
        {
            double P = (a + b + c) / 2;
            double T = a * b * c / (4 * Math.Sqrt(P * (P - a) * (P - b) * (P - c)));
            double area = Math.PI * Math.Pow(T, 2);
            return area;
        }
        static void Main(string[] args)
        {
            double a = ReadNumber("Please enter a: ");
            double b = ReadNumber("Please enter b: ");
            double c = ReadNumber("Please enter c: ");

            Console.WriteLine($"The circle area that has a = {a} and b = {b} and c = {c} as triangle sides is: {CalculateCircleAreaDescribedAroundArbitraryTriangle(a, b, c)}");
        }
    }
}

namespace Problem17
{
    internal class Program
    {
        // Write a program to calculate triangle area then print it 

        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateTriangleArea(double a, double h)
        {

            return (0.5 * a * h); // Area = 0.5 * a * h
        }
        static void Main(string[] args)
        {
            double a = ReadNumber("Please enter the long side of the triangle: ");
            double h = ReadNumber("Please enter the height: ");

            Console.WriteLine($"\nThe triangle area that has {h}, {a} sides is {CalculateTriangleArea(h, a)}");
        }
    }
}

namespace Problem15
{
    internal class Program
    {
        // Write a program to calculate the rectangle area
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int CalculateRectangleArea(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            int a = ReadNumber("Please enter the first side height: ");
            int b = ReadNumber("Please enter the second side height: ");

            Console.WriteLine($"\nThe rectangle area that has {a}, {b} sides is {CalculateRectangleArea(a,b)}");

        }
    }
}

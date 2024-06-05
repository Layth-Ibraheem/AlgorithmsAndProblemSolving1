namespace Problem21
{
    internal class Program
    {
        // Write a program that caculates the circle area along the circumference

        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateCircleAreaIAlongCircumference(double circumference)
        {
            return Math.Pow(circumference, 2) / (Math.PI * 4);
        }
        static void Main(string[] args)
        {
            double circumference = ReadNumber("Please enter circumference: ");
            Console.WriteLine($"The circle area that has a circumference = {circumference} is: {CalculateCircleAreaIAlongCircumference(circumference)}");
        }
    }
}

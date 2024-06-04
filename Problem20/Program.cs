namespace Problem20
{
    internal class Program
    {
        // Write a program that caculates the circle area inscribed in a square
        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateCircleAreaInscribedInSuare(double squareSide)
        {
            return Math.PI * Math.Pow(squareSide / 2, 2);
        }
        static void Main(string[] args)
        {
            double squareSide = ReadNumber("Please enter square side: ");
            Console.WriteLine($"The circle area that has a square side = {squareSide} is: {CalculateCircleAreaInscribedInSuare(squareSide)}");
        }
    }
}

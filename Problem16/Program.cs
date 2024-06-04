namespace Problem16
{
    internal class Program
    {
        // Write a program to calculate rectangle area through diagonal and side area of rectangle then print it 

        static double ReadNumber(string message)
        {
            Console.WriteLine(message);
            double result = double.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateRectangleAreaThroughDiagonal(double diagonal, double side)
        {
            double area = side * Math.Sqrt(Math.Pow(diagonal, 2) - Math.Pow(side, 2)); // Area = side * ( (diagonal * diagonal) - (side * side) )
            return area;
        }
        static void Main(string[] args)
        {
            double side = ReadNumber("Please enter the sideArea: ");
            double diagonal = ReadNumber("Please enter the diagonal: ");

            Console.WriteLine($"\nThe rectangle area that has {diagonal}, {side} sides is {CalculateRectangleAreaThroughDiagonal(diagonal, side)}");
        }
    }
}

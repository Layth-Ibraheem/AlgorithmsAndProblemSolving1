namespace Problem31
{
    internal class Program
    {
        // Write a program to ask the user to enter a number then print number^2, number^3, number^4

        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateNumberToPower(int number, int pow)
        {
            // using Math class: 
            //return Math.Pow(number, pow);

            // recursion
            if (pow == 1)
                return number;
            return number * CalculateNumberToPower(number, pow - 1);
        }
        static void Main(string[] args)
        {
            int N = ReadNumber("Please enetr the number which you want to calculate it`s 2, 3, 4 power: ");
            Console.WriteLine($"\n{N}^2 = {CalculateNumberToPower(N, 2)}");
            Console.WriteLine($"\n{N}^3 = {CalculateNumberToPower(N, 3)}");
            Console.WriteLine($"\n{N}^4 = {CalculateNumberToPower(N, 4)}");

        }
    }
}

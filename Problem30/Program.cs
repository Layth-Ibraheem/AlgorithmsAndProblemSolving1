namespace Problem30
{
    internal class Program
    {
        // Write a program to calculate the factorial of N (N!)

        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int CalculateFactorial(int N)
        {
            if (N == 1)
                return 1;
            return N * CalculateFactorial(N - 1);
            // Or we can type 
            // return N == 1? 1 : N * CalculateFactorial(N - 1);
        }
        static void Main(string[] args)
        {
            int N = ReadNumber("Please enetr the number which you want to calculate it`s factorial: ");
            Console.WriteLine($"\nThe factorial of {N} ({N}!) = {CalculateFactorial(N)}");
        }
    }
}

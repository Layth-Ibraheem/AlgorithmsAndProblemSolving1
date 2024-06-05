namespace Problem28
{
    internal class Program
    {
        // Write a program to sum the odd numbers from 1 to N

        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int SumOddNumbersFrom11ToN(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (IsOddNumber(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        static bool IsOddNumber(int number)
        {
            return (number % 2 != 0);
        }
        static void Main(string[] args)
        {
            int N = ReadNumber("Please enter the number which you want to sum the odd numbers from 1 untill this number: ");

            Console.WriteLine($"The sum of odd numbers from 1 to {N} is: {SumOddNumbersFrom11ToN(N)}");
        }
    }
}

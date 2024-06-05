namespace Problem29
{
    internal class Program
    {
        // Write a program to sum the even numbers from 1 to N

        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int SumEvenNumbersFrom1ToN(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (IsEvenNumber(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        static bool IsEvenNumber(int number)
        {
            return (number % 2 == 0);
        }
        static void Main(string[] args)
        {
            int N = ReadNumber("Please enter the number which you want to sum the even numbers from 1 untill this number: ");

            Console.WriteLine($"The sum of even numbers from 1 to {N} is: {SumEvenNumbersFrom1ToN(N)}");
        }
    }
}

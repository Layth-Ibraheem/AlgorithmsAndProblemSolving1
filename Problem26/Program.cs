namespace Problem26
{
    internal class Program
    {
        // Write a program to print the numbers from 1 to N

        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static void PrintNumbersFrom1To(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int N = ReadNumber("Please enter the number shich you want to print numbers from 1 untill this number: ");
            Console.WriteLine($"\nNumbers from 1 to {N}: ");
            PrintNumbersFrom1To(N);
        }
    }
}

namespace Problem27
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
        static void PrintNumbersFromNTo1(int N)
        {
            for (int i = N; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int N = ReadNumber("Please enter the number shich you want to start from and print the numbers down to 1: ");
            Console.WriteLine($"\nNumbers from {N} to 1: ");
            PrintNumbersFromNTo1(N);
        }
    }
}

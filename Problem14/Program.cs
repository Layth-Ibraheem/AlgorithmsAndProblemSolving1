namespace Problem14
{
    internal class Program
    {
        // Write a program that reads 2 numbers then swap them

        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static void SwapNumberMethod1(ref int number1, ref int number2)
        {
            number1 += number2;
            number2 = number1 - number2;
            number1 -= number2;
        }
        static void SwapNumberMethod2(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
        static void Main(string[] args)
        {
            int number1 = ReadNumber("Please enter the first number: ");
            int number2 = ReadNumber("Please enter the second number: ");

            Console.WriteLine("Befor Swap");
            Console.WriteLine("Number1: " + number1);
            Console.WriteLine("Number2: " + number2);

            SwapNumberMethod1(ref number1, ref number2);
            Console.WriteLine("\nAfter Swap");
            Console.WriteLine("Number1: " + number1);
            Console.WriteLine("Number2: " + number2);

        }
    }
}

namespace Problem12
{
    internal class Program
    {
        // Write a program to get the max number between tow numbers that the user entered

        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int GetMaxNumber(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        static void Main(string[] args)
        {
            int number1 = ReadNumber("Enter the first number: ");
            int number2 = ReadNumber("Enter the second number: ");
            Console.WriteLine($"The max number between {number1} and {number2} is: {GetMaxNumber(number1, number2)}");
        }
    }
}

namespace Problem13
{
    internal class Program
    {
        // Write a program to get the max number between three numbers that the user entered

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
            int number2 = ReadNumber("Enter the secondS number: ");
            int number3 = ReadNumber("Enter the third number: ");
            int firstMaxNumber = GetMaxNumber(number1, number2);
            Console.WriteLine($"The max number between {number1}, {number2}, {number3} is: {GetMaxNumber(firstMaxNumber, number3)}");
        }
    }
}

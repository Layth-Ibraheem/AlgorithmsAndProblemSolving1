namespace Problem10
{
    // Write a program the read the users marks (3 marks) and calculate teh marks average
    internal class Program
    {
        static float ReadNumber(string message)
        {
            Console.WriteLine(message);
            float result = float.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static float GetSum(float number1, float number2, float number3)
        {
            return number1 + number2 + number3;
        }
        static float CalculateAverage(float number1, float number2, float number3)
        {
            return GetSum(number1, number2, number3) / 3;
        }
        static void Main(string[] args)
        {
            float number1 = ReadNumber("Please enter the first number: ");
            float number2 = ReadNumber("Please enter the second number: ");
            float number3 = ReadNumber("Please enter the third number: ");
            Console.WriteLine($"The Average Of {number1}, {number2}, {number3} is {CalculateAverage(number1, number2, number3)}");
        }
    }
}

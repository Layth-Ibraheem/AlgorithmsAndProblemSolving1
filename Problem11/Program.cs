namespace Problem11
{
    internal class Program
    {
        // Write a program the read the users marks (3 marks) and calculate teh marks average then print "Pass" if the average greater than or equasl 50, "Fail" otherwise
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
        static bool IsPass(float average)
        {
            return average >= 50;
        }
        static void Main(string[] args)
        {
            float number1 = ReadNumber("Please enter the first number: ");
            float number2 = ReadNumber("Please enter the second number: ");
            float number3 = ReadNumber("Please enter the third number: ");
            float average = CalculateAverage(number1,number2, number3);
            Console.WriteLine($"The Average Of {number1}, {number2}, {number3} is {average}\n");
            if (IsPass(average))
            {
                Console.WriteLine("Congrats, You Passed The Exam =-)");
            }
            else
            {
                Console.WriteLine("Sorry, You Failed The Exam =-(");
            }
        }
    }
}

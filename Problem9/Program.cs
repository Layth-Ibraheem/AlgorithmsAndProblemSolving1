namespace Problem9
{
    // Write a program that asks the user to enter three numbers then calculate there sum
    internal class Program
    {
        static int ReadNumber(string message)
        {
            do
            {
                Console.WriteLine(message);

                string? enteredNumber = Console.ReadLine();

                if (int.TryParse(enteredNumber, out int number))
                {
                    return number;
                }
            } while (true);
        }
        static int GetSum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
        static void Main(string[] args)
        {
            int number1 = ReadNumber("Please enter the first number: ");
            int number2 = ReadNumber("Please enter the second number: ");
            int number3 = ReadNumber("Please enter the third number: ");

            Console.WriteLine($"{number1} + {number2} + {number3} = {GetSum(number1, number2, number3)}");
        }
    }
}

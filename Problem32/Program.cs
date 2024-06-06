namespace Problem32
{
    internal class Program
    {
        // Write a program to ask the user to enter a Number and a Power then print Number^Power 
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static double CalculateNumberToPower(int number, int pow)
        {
            //Method 1:

            // using Math class: 
            //return Math.Pow(number, pow);

            //Method 2:

            // recursion
            //if (pow == 1)
            //    return number;
            //return number * CalculateNumberToPower(number, pow - 1);

            //Method 3:

            // using for loop
            int sum = 1;
            for (int i = pow; i > 0; i--)
            {
                sum *= number;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int Number = ReadNumber("Please enetr the number: ");
            int Power = ReadNumber("Please enetr the power: ");

            Console.WriteLine($"\n{Number}^{Power} = {CalculateNumberToPower(Number, Power)}");
        }
    }
}

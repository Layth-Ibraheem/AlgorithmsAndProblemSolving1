namespace Problem7
{
    // Write a program that asks the user to enter a number then print the half of the number
    internal class Program
    {
        static int ReadNumber()
        {
            do
            {
                Console.WriteLine("Please enter a number to calculate the half of it: ");

                string? enteredNumber = Console.ReadLine();

                if (int.TryParse(enteredNumber, out int number))
                {
                    return number;
                }
            } while (true);
        }
        static int GetTheHalfOfNumber(int number)
        {
            return number / 2;
        }
        static void Main(string[] args)
        {
            int number = ReadNumber();
            Console.WriteLine($"The half of {number} is {GetTheHalfOfNumber(number)}");
        }
    }
}

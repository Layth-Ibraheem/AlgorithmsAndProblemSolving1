namespace Problem3
{
    // Write a program to ask the user to enter a number then print "ODD" if its odd and "EVEN" if its even
    internal class Program
    {
        enum enOddOrEven { Odd,Even};
        static int ReadNumber()
        {
            do
            {
                Console.WriteLine("Please enter a number to check if its odd or even: ");

                string? enteredNumber = Console.ReadLine();

                if (int.TryParse(enteredNumber, out int number))
                { 
                    return number;
                }
            } while (true);
        }
        static enOddOrEven OddOrEven(int number)
        {
            if(number % 2 == 0)
            {
                return enOddOrEven.Even;
            }
            return enOddOrEven.Odd;
        }
        static void Main(string[] args)
        {
            if(OddOrEven(ReadNumber()) == enOddOrEven.Odd)
            {
                Console.WriteLine("The Number Is 'ODD'");
            }
            else
            {
                Console.WriteLine("The Number Is 'EVEN'");
            }
        }
    }
}

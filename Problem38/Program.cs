namespace Problem38
{
    internal class Program
    {
        // Write a program to ask the user to enter a number then check if this number is prime or not prim
        // The prime number is the number that can divide by only one and the number itself

        enum enNumberStatus
        {
            Prime,
            NotPrime
        }
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static enNumberStatus IsPrime(int number)
        {
            for (int i = 2; i < number / 2; i++)
            {
                if(number % i == 0)
                    return enNumberStatus.NotPrime;
            }
            return enNumberStatus.Prime;
        }
        static void Main(string[] args)
        {
            int number = ReadNumber("Please enter the number to heck if it is prime or not prime: ");
            if(IsPrime(number) == enNumberStatus.NotPrime)
            {
                Console.WriteLine("The number is not prime");
            }
            else
            {
                Console.WriteLine("The number is prime");
            }
        }
    }
}

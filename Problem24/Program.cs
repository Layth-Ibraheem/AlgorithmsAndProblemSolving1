namespace Problem24
{
    internal class Program
    {
        // Write a program to ask the user to enter his age and if age is between 18 and 45 print 'Valid Age' else print 'Invalid Age'

        static byte ReadNumber(string message)
        {
            Console.WriteLine(message);
            byte result = byte.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static bool IsNumberBetween(byte number, byte min, byte max)
        {
            return number >= min && number <= max;
        }
        static bool IsValidAge(byte age)
        {
            return IsNumberBetween(age, 18, 45);
        }
        static void Main(string[] args)
        {
            byte age = ReadNumber("Please enter your age: ");
            if(IsValidAge(age))
            {
                Console.WriteLine("Valid Age");
            }
            else
            {
                Console.WriteLine("Invalid Age");
            }
        }
    }
}

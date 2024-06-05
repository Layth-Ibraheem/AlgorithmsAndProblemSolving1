namespace Problem25
{
    internal class Program
    {
        // Write a program to ask the user to enter his age and if age is between 18 and 45 print 'Valid Age' else print 'Invalid Age' and re-ask the user to enter a valid age

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
        static byte ReadAgeUntillValid()
        {
            byte age = ReadNumber("Please enter your age: ");
            while (!IsValidAge(age))
            {
                age = ReadNumber("Invalid age, please enter a valid age: ");
            }
            return age;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Your age is: {ReadAgeUntillValid()}");
        }
    }
}

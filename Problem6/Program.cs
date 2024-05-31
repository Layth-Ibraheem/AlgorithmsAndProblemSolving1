namespace Problem6
{
    // Write a program that asks the user to enter his first name and last name then print the full name on the screen
    internal class Program
    {
        static string? ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        static void PrintFullName(string? FirstName, string? LastName)
        {
            Console.WriteLine($"Hello {FirstName} {LastName}, Welcom");
        }
        static void Main(string[] args)
        {
            PrintFullName(ReadString("Please Enter Your First Name: "), ReadString("Please Enter Your Last Name: "));
        }
    }
}

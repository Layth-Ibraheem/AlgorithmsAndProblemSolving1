namespace Problem2
{
    // Write a program that asks a user to enter the name then print it
    internal class Program
    {
        static string? ReadName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }
        static void PrintName(string? name)
        {
            Console.WriteLine($"Hello {name}, Welcom");
        }
        static void Main(string[] args)
        {
            PrintName(ReadName());
        }
    }
}

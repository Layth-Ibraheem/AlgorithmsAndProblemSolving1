namespace Problem37
{
    internal class Program
    {
        // Write a program to read numbers from user then sum them untill the user enter -99 stop and print the sum
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int SumUntill()
        {
            int sum = 0;
            int number = 0;
            do
            {
                // Method1: apply it by putting the condition in the do-while loop to true

                //int number = ReadNumber("Please enter the number to add: ");
                //if (number == -99)
                //    break;
                //sum += number;


                // Method2

                sum += number;
                number = ReadNumber("Please enter the number to add: ");

            } while (number != -99);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Ths sum is: {SumUntill()}");
        }
    }
}

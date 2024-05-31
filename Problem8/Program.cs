namespace Problem8
{
    // Write a program that asks the user to enter his mark and print "Pass" if the mark was greater then or equals 50, otherwise print "Fail"
    internal class Program
    {
        static int ReadMark()
        {
            do
            {
                Console.WriteLine("Please enter your mark: ");

                string? enteredNumber = Console.ReadLine();

                if (int.TryParse(enteredNumber, out int number))
                {
                    return number;
                }
            } while (true);
        }
        static bool IsPassing(int mark)
        {
            return mark >= 50;
        }
        static void Main(string[] args)
        {
            if(IsPassing(ReadMark()))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}

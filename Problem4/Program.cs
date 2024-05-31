namespace Problem4
{
    // Write a program to ask the user to enter if he has a driver license and his age then print "Hired" if he has a driver license and his age is greater than 21
    // otherwise print "Rejected"
    internal class Program
    {
        static bool ReadIfHasDriverLicense()
        {
            Console.WriteLine("Please enter y or yes if you have a driver license: ");

            string? answer = "";
            answer = Console.ReadLine();

            if (answer == null)
                return false;

            return answer.ToLower() == "y" || answer.ToLower() == "yes";
        }
        static int ReadAge()
        {
            Console.WriteLine("Please enter the age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");
            return age;
        }
        static bool IsHired(bool hasDrivingLicense, int age)
        {
            return hasDrivingLicense && age > 21;
        }

        static void Main(string[] args)
        {
            if (IsHired(ReadIfHasDriverLicense(), ReadAge()))
            {
                Console.WriteLine("Congrats, You are hired");
            }
            else
            {
                Console.WriteLine("Sorry you do not satisfy this job conditions");
            }
        }
    }
}

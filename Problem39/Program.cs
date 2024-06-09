namespace Problem39
{
    internal class Program
    {
        // Write a program to read the Total Bill and the Paid Cash then calculate the remainder to be paid back
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static int CalculateRemainder(int totalBill, int paidCash)
        {
            return totalBill - paidCash;
        }
        static void Main(string[] args)
        {
            int totalBill = ReadNumber("Please enter the total bill: ");
            int paidCash = ReadNumber("Please enter the paid cash: ");
            Console.WriteLine($"Total Bill: {totalBill}, Paid Cash: {paidCash}");
            Console.WriteLine($"Final result: {-CalculateRemainder(totalBill, paidCash)}");
        }
    }
}

namespace Problem36
{
    internal class Program
    {
        // Write a program to ask the user to enter: Number1, Number2, Operation
        // then perform the calculating between those numbers based on the operation

        enum enOperationType
        {
            Add,
            Sub,
            Multiply,
            Division
        }
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine() ?? "0");
            return result;
        }
        static enOperationType ReadOperation()
        {
            Console.WriteLine("Please enter the operation you want to perform between the numbers: ");
            Console.WriteLine("1- Sum the numbers");
            Console.WriteLine("2- Subtract the numbers");
            Console.WriteLine("3- Multiply the numbers");
            Console.WriteLine("4- Divide the numbers");
            int choice = ReadNumber("");
            switch (choice)
            {
                case 1:
                    return enOperationType.Add;
                case 2:
                    return enOperationType.Sub;
                case 3:
                    return enOperationType.Multiply;
                case 4:
                    return enOperationType.Division;
                default:
                    return enOperationType.Add;
            }
        }
        static int PerformCalculating(int number1, int number2, enOperationType operationType)
        {
            switch (operationType)
            {
                case enOperationType.Add:
                    return number1 + number2;

                case enOperationType.Sub:
                    return number1 - number2;

                case enOperationType.Multiply:
                    return number1 * number2;

                case enOperationType.Division:
                    return number2 == 0 ? 0 : number1 / number2;

                default:
                    return number1 + number2;
            }
        }
        static char GetOperationTypeSymbol(enOperationType operationType)
        {
            switch (operationType)
            {
                case enOperationType.Add:
                    return '+';

                case enOperationType.Sub:
                    return '-';

                case enOperationType.Multiply:
                    return '*';

                case enOperationType.Division:
                    return '/';

                default:
                    return '+';
            }
        }
        static void Main(string[] args)
        {
            int number1 = ReadNumber("Please enter the first number: ");
            int number2 = ReadNumber("Please enter the second number: ");
            enOperationType operationType = ReadOperation();

            Console.WriteLine($"\n{number1} {GetOperationTypeSymbol(operationType)} {number2} = {PerformCalculating(number1, number2, operationType)}");
        }
    }
}
namespace Problem33
{
    internal class Program
    {
        // Write a program that asks the user to enter a grade the if 
        // grade between 90 and 100 print 'A'
        // grade between 80 and 89 print  'B'
        // grade between 70 and 79 print  'C'
        // grade between 60 and 69 print  'D'
        // grade between 50 and 59 print  'E'
        // otherwise                      'F'
        static int ReadNumberBetween(string message, int min, int max)
        {
            int number = 0;
            do
            {
                Console.WriteLine(message);
                number = int.Parse(Console.ReadLine() ?? "0");

            } while (number < min || number > max);
            return number;
        }
        static char GetGradeChar(int grade)
        {
            if (grade >= 90)
                return 'A';
            if (grade >= 80)
                return 'B';
            if (grade >= 70)
                return 'C';
            if (grade >= 60)
                return 'D';
            if (grade >= 50)
                return 'E';

            return 'F';
        }
        static void Main(string[] args)
        {
            int grade = ReadNumberBetween("Please enter the grade, Note: the grade must be between 0 and 100", 0, 100);
            Console.WriteLine($"Your grade is {grade}, {GetGradeChar(grade)}");
        }
    }
}

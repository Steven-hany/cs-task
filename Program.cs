using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter student {i + 1} name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Math grade: ");
            int math = int.Parse(Console.ReadLine());

            Console.Write("Enter English grade: ");
            int english = int.Parse(Console.ReadLine());

            Console.Write("Enter Science grade: ");
            int science = int.Parse(Console.ReadLine());

            double average = (math + english + science) / 3.0;
            string result = average >= 50 ? "PASS" : "FAIL" \n ;

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Math: {math}, English: {english}, Science: {science}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("--------------------------------");
        }
    }
}

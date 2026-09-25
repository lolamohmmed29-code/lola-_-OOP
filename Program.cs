using System;

class CourseResult
{
    private double mark;

    public string StudentName { get; set; }

    public double Mark
    {
        get { return mark; }
        set
        {
            if (value >= 0 && value <= 100)
                mark = value;
            else
                Console.WriteLine("Invalid mark");
        }
    }

    public char Grade
    {
        get
        {
            if (mark >= 90) return 'A';
            else if (mark >= 80) return 'B';
            else if (mark >= 70) return 'C';
            else if (mark >= 60) return 'D';
            else return 'F';
        }
    }

    public bool Passed
    {
        get { return mark >= 50; }
    }

    public void PrintResult()
    {
        Console.WriteLine("Name: " + StudentName);
        Console.WriteLine("Mark: " + Mark);
        Console.WriteLine("Grade: " + Grade);
        Console.WriteLine("Passed: " + Passed);
    }
}

class Program
{
    static void Main()
    {
        CourseResult student = new CourseResult();

        Console.Write("Enter name: ");
        student.StudentName = Console.ReadLine();

        Console.Write("Enter mark: ");
        student.Mark = Convert.ToDouble(Console.ReadLine());

        student.PrintResult();

        Console.WriteLine("Invalid test:");
        student.Mark = 120;
    }
}
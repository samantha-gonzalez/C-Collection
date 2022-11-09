using System;
using static System.Console;
class Admission
{
    static void Main()
    {
        string gpa, testScore;
        Write("Enter your GPA >> ");
        gpa = ReadLine();
        Write("Enter your test score >> ");
        testScore = ReadLine();

        double gpaNum = Convert.ToDouble(gpa);
        double tScore = Convert.ToDouble(testScore);

        if ((gpaNum >= 3.60 && tScore >= 80.00) || (gpaNum <= 3.60 && tScore >= 90.00))
            WriteLine("You are accepted!");
        else
            WriteLine("You are rejected.");
    }
}

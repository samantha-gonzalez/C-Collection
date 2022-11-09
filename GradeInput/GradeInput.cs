using System;
using static System.Console;
class GradeInput
{
    static void Main()
    {
        string score;
        Write("Please enter your course score >> ");
        score = ReadLine();

        double scoreNum = Convert.ToDouble(score);

        if (scoreNum >= 90.00)
            WriteLine("Your course grade is: A");
        else if (scoreNum >= 80.00 && scoreNum < 90.00)
            WriteLine("Your course grade is: B");
        else if (scoreNum >= 70.00 && scoreNum < 80.00)
            WriteLine("Your course grade is: C");
        else if (scoreNum >= 60.00 && scoreNum < 70.00)
            WriteLine("Your course grade is: D");
        else
            WriteLine("Your course grade is: F");
    }
}

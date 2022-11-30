using System;
using static System.Console;

internal class Admission_exe7
{
   static void Main()
   {
        double gpa, testScore;
        string result;

        Write("Enter your GPA >> ");
        gpa = Convert.ToDouble(ReadLine());
        Write("Enter your test score >> ");
        testScore = Convert.ToDouble(ReadLine());

        MakeDecision(gpa, testScore);
        result = MakeDecision(gpa,testScore);
        WriteLine(result);
        
    }
   public static string MakeDecision(double gpa, double testScore)
   {
        if ((gpa >= 3.2 && testScore >= 70.00) || (gpa <= 3.2 && testScore >= 80.00))
            return "accept";
        else
            return "reject"; 
    }
}


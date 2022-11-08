using System;
using static System.Console;

internal class ArrayStudentID
{
    static void Main()
    {
        int[] studentID = {1012, 1033, 1156, 1569, 1970};
        string[] fName = {"Bones", "Welma", "Frank", "Hanes", "Jack"};
        string[] lName = {"Smith", "Seger", "Mathers", "Solo", "Bush"};
        string[] year = {"freshman", "sophmore", "senior", "junior", "freshman"};

        Write("Please enter a student ID >> ");
        int userInput = Convert.ToInt32(ReadLine());

        int x = Array.IndexOf(studentID, userInput);
     

        if (x != -1)
        { 
            WriteLine("The student's first name is {0}", fName[x]);
            WriteLine("The student's last name is {0}", lName[x]);
            WriteLine("The student is a {0}", year[x]);
        }
        else
            WriteLine("Sorry - student not found");
    }
}


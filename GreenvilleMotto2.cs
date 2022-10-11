using System;
using static System.Console;
class GreenvilleMotto2
{
    static void Main()
    {
        Write("Enter a motto: ");
        string motto = ReadLine();
        int count = motto.Length + 4;

        for (int i = 0; i < count; i++)
        {
            Write("*");
        }
        WriteLine();
        WriteLine("* {0} *", motto);
        for (int i = 0; i < count; i++)
        {
            Write("*");
        }

        WriteLine();
        WriteLine("Motto Length: {0}", motto.Length);

    }
        
}

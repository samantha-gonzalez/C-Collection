using System;
using static System.Console;
class NestedLoop
{
    static void Main()
    {
        int i, j, k;
         for (i = 1; i <= 10; ++i)
         {
             for (j = 1; j <= 10 - i; ++j)
             {
                Write(" ");
             }
             for (k = 1; k<= i; k++)
             {
                Write("*");
            }
              WriteLine();
         }

    }
}
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;
class TestScoreArray
{
    static void Main()
    {
        double[] score = { 85, 98, 100, 73, 67, 82, 92, 87 };
        
        Write("The eight numbers are");
        double sum, avg;
        sum = 0.0;
        for (int i = 0; i <= 7; ++i)
        {
            if (i == 7)
            {
                Write(" {0}.\n", score[i]);
            }
            else
            {
                Write(" {0}, ", score[i]);
            }
            sum += score[i];
        }
        avg = sum / 8;
        WriteLine("The average is {0} ", avg);
    }
}

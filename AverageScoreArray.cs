using System;
using static System.Console;
class TestScoreArray
{
    static void Main()
    {
        string StringScore;
        double[] scores = new double[5]; 

        for (int i = 0; i < 5; ++i)
        {
            Write("Enter an integer test score >> ");
            StringScore = ReadLine();

            double scoreNum = Convert.ToDouble(StringScore);
            scores[i] = scoreNum;
        }

        Write("The integers entered are:\n");
        double sum, avg;
        sum = 0.0;
        
        for (int i = 0; i < 5; ++i)
        {
            WriteLine(" {0}", scores[i]);

            sum += scores[i];
        }
        avg = sum / 5;
        WriteLine("The average score is {0} ", avg);
    }
}

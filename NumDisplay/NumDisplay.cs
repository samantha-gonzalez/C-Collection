using System;
using System.Data.Common;
using static System.Console;
class NumDisplay
{
    static void Main()
    {
        string rowsString, columnsString;
        Write("Enter the number of rows: ");
        rowsString = ReadLine();
        int rows = Convert.ToInt32(rowsString);

        Write("Enter the number of columns: ");
        columnsString = ReadLine();
        int columns = Convert.ToInt32(columnsString);

        int i, j;
        for (i = 0; i < rows; ++i)
        {
            for (j = 0; j < columns; ++j)
            {
                Write("{0}\t", ((columns * i) + j + 1));
            }
            WriteLine();
        }

    }
}
using System;
using static System.Console;
using System.Collections.Generic;
using System.Diagnostics;

class PaintingEstimate
{
    static void Main()
    {
        double length, width;
       
        Write("Enter the length of the room in feet >> ");
        length = Convert.ToDouble(ReadLine());
        Write("Enter the width of the room in feet >> ");
        width = Convert.ToDouble(ReadLine());
        PaintCost(length, width);
        double TotalCost = PaintCost(length, width);
        WriteLine("The cost of painting the room is {0:C2}", TotalCost );
    }
    private static double PaintCost(double length, double width)
    {
        double SquareFoot = (2*(15 * length)) + (2*(15 * width)) + (length * width);
        double JobP = SquareFoot * 12;
        return JobP;
    }
}
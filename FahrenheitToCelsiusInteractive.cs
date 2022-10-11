using System;
using static System.Console;
class FahrenheitToCelsiusInteractive
{
    static void Main()
    {
        Write("Enter Fahrenheit degrees >> ");

        string fString = ReadLine();
        double f = Convert.ToDouble(fString);
        double result = f - 32;
        double c = result * 5 / 9;
        string cString = c.ToString("F2");
        

        WriteLine("{0:F2} F is {1:F2} C", f, c);
    }
}

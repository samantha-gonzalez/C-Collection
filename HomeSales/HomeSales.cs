using System;
using static System.Console;
class HomeSales
{
    static void Main()
    {
         string initial,salesString;
         Write("Please enter your initial (D, E, or F) >> ");
         initial = ReadLine();

            if (initial == "D" || initial == "d")
            {
                Write("Please enter your sales amount >> ");
                salesString = ReadLine();

                double sales = Convert.ToDouble(salesString);
                WriteLine("The sales for Danielle is ${0:n}", sales);
            }
            else if (initial == "E" || initial == "e")
            {
                Write("Please enter your sales amount >> ");
                salesString = ReadLine();

                double sales = Convert.ToDouble(salesString);
                WriteLine("The sales for Edward is ${0:n}", sales);
            }
            else if (initial == "F" || initial == "f")
            {
                Write("Please enter your sales amount >> ");
                salesString = ReadLine();

                double sales = Convert.ToDouble(salesString);
                WriteLine("The sales for Francis is ${0:n}", sales);
            }
            else
                WriteLine("Invalid initial");

    }
 
}

using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
     string  lastYear, thisYear;
     Write("Enter the contestants from last year >> ");
     lastYear = ReadLine();
     Write("Enter the contestants from this year >> ");
     thisYear = ReadLine();

     WriteLine("Contestants from last year is {0}", lastYear);
     WriteLine("Contestants from this year is {0}", thisYear);

     double thisY = Convert.ToDouble(thisYear);
     double lastY = Convert.ToDouble(lastYear);
     double revenue = thisY * 25;
     WriteLine("Revenue expected from this year is ${0:F2}", revenue);

     bool years = thisY >= lastY; 
     WriteLine("It is {0} this year has more contestants", years);
    }
}

using System;
using static System.Console;
using System.Collections.Generic;
using System.Diagnostics;
internal class MealPriceCalculation
{
  static void Main() //accept meal price and tip
  {
        double MealPrice, Tip, TotalCost, MealPrice2, TotalPercentCost;
        int TipPercent;

        Write("Please enter the meal price in dollar amount >> $");
        MealPrice = Convert.ToDouble(ReadLine());
        Write("Please enter the tip in dollar amount >> $");
        Tip = Convert.ToDouble(ReadLine());
        CalPrice(MealPrice,Tip);
        TotalCost = CalPrice(MealPrice, Tip);
        WriteLine("The meal price is {0:C2}",TotalCost);

        Write("Please enter the meal price in dollar amount >> $");
        MealPrice2 = Convert.ToDouble(ReadLine());
        Write("Please enter the tip percentage in whole number (if 15%, enter 15) >> %");
        TipPercent = Convert.ToInt32(ReadLine());
        CalPrice(MealPrice2, TipPercent);
        TotalPercentCost = CalPrice(MealPrice2, TipPercent);
        WriteLine("The meal Price is {0:C2}", TotalPercentCost);
    }

  private static double CalPrice(double MealPrice, double Tip) //calculate total meal price
  {
        double ToalMP = MealPrice + Tip;
        return ToalMP;
  }
  private static double CalPrice(double MealPrice2, int TipPercent) //calculate tip in percent
  {
        double PercentToDec = (0.01 * TipPercent);
        double CalcTip = PercentToDec * MealPrice2;
        double CalTotal = CalcTip + MealPrice2;
        return CalTotal;
  }
}

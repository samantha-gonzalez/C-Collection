using System;
using static System.Console;
using System.Collections.Generic;


class MainMethod
{
    static void Main()
    {
        double price;
        int quantity;
     
        Write("Enter the unit price in $ >> ");
        price = Convert.ToDouble(ReadLine());
        Write("Enter the quantity of purchase >> ");
        quantity = Convert.ToInt32(ReadLine());

        CalSales(price, quantity);
        double Tsales = CalSales(price, quantity);
        WriteLine("The total purchase is {0:C2}", Tsales);
    }
    private static double CalSales(double price, int quantity)
    {
        double totalSales = price * quantity;
        return totalSales;
    }
}



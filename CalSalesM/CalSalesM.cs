using System;
using static System.Console;
using System.Collections.Generic;

class CalSalesM
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
    }
    private static void CalSales(double price, int quantity)
    {
        double totalSales = price * quantity;
        WriteLine("The total purchase is {0:C2}", totalSales); 
    }
}


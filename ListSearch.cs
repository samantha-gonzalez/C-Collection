using System;
using static System.Console;
using System.Collections.Generic;

internal class ListSearch
{
    static void Main()
    {
        List<int> itemNum = new List<int> { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };
        int itemInput;
        while (true)
        {
            Write("Enter an item number or 0 to exit >> ");
            itemInput = Convert.ToInt32(ReadLine()); 

            if (itemInput == 0)
                break;
            
            int x = itemNum.IndexOf(itemInput);

            if (x != -1)
            {
                WriteLine("The item is found");
            }
            else
            {
                itemNum.Add(itemInput);
                WriteLine("Item not found and back ordered");
            }
        }
    }
}

using System;
using static System.Console;

class AdApp1
 {
    static void Main()
    {
        ClassifiedAd ad1 = new ClassifiedAd();
        ad1.Category = "Food";
        ad1.Words = 120;
        ad1.Price = 0.09 * ad1.Words;
        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", ad1.Words, ad1.Category, ad1.Price);
        
        ClassifiedAd ad2 = new ClassifiedAd();
        ad2.Category = "Automobile";
        ad2.Words = 200;
        ad2.Price = 0.09 * ad2.Words;
        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", ad2.Words, ad2.Category, ad2.Price);
    }
}

class ClassifiedAd //object class
{
    public string Category;
    public int Words; 
    public double Price;
}

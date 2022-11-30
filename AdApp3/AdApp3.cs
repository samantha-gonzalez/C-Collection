using System;
using static System.Console;

class AdApp3
{
    static void Main()
    {
        ClassifiedAd ad1 = new ClassifiedAd();
        Write("What is the category of the first advertisement? ");
        ad1.Category = ReadLine();
        Write("How many words does it have? ");
        int Words1 = Convert.ToInt32(ReadLine());
        ad1.CalPrice(Words1);

        ClassifiedAd ad2 = new ClassifiedAd();
        Write("What is the category of the second advertisement? ");
        ad2.Category = ReadLine();
        Write("How many words does it have? ");
        int Words2 = Convert.ToInt32(ReadLine());
        ad2.CalPrice(Words2);

        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", Words1, ad1.Category, ad1.Price);
        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", Words2, ad2.Category, ad2.Price);
    }
}

class ClassifiedAd //object class
{
    public string Category;
    public double Price;
    public void CalPrice(int Words) //method
    {
        Price = 0.09 * Words;
    }
}
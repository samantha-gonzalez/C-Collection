using System;
using static System.Console;

class AdApp2
{
    static void Main()
    {
        ClassifiedAd ad1 = new ClassifiedAd();
        Write("What is the category of the first advertisement? ");
        ad1.Category = ReadLine();
        Write("How many words does it have? ");
        ad1.Words = Convert.ToInt32(ReadLine());
        ad1.Price = 0.09 * ad1.Words;

        ClassifiedAd ad2 = new ClassifiedAd();
        Write("What is the category of the second advertisement? ");
        ad2.Category = ReadLine();
        Write("How many words does it have? ");
        ad2.Words = Convert.ToInt32(ReadLine());
        ad2.Price = 0.09 * ad2.Words;

        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", ad1.Words, ad1.Category, ad1.Price);
        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", ad2.Words, ad2.Category, ad2.Price);
    }
}

class ClassifiedAd //object class
{
    public string Category;
    public int Words;
    public double Price;
}

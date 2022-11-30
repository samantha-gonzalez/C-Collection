using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

class AdApp4
{
    static void Main()
    {
        
        Write("What is the category of the first advertisement? ");
        string Category1 = ReadLine();
        Write("How many words does it have? ");
        int Words1 = Convert.ToInt32(ReadLine());
        ClassifiedAd ad1 = new ClassifiedAd(Category1, Words1); //call user defined constructor
        ad1.CalPrice(); //call method

        Write("What is the category of the second advertisement? ");
        string Category2 = ReadLine();
        Write("How many words does it have? ");
        int Words2 = Convert.ToInt32(ReadLine());
        ClassifiedAd ad2 = new ClassifiedAd(Category2, Words2);
        ad2.CalPrice();

        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", ad1.Words, ad1.Category, ad1.Price);
        WriteLine("The classified ad with {0} words in category {1} costs {2:C2}", ad2.Words, ad2.Category, ad2.Price);
    }
}

class ClassifiedAd //object class
{
    public string Category;
    public int Words;
    public double Price;

    public ClassifiedAd(string category, int words) //user defined constructor
    {
        Category = category;
        Words = words;
    }

    public void CalPrice() //method
    {
        Price = 0.09 * Words;
    }
}
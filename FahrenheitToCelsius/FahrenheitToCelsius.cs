using static System.Console;
class FahrenheitToCelsius
 {
    static void Main()
     {
       double f = 200;
       string fString = f.ToString("F2");
       double result = f - 32;
       double c = result * 5 / 9;
       string cString = c.ToString("F2");

       WriteLine("{0:F2} Fahrenheit degrees is {1:F2} Celsius degrees. ", f, c);
     }
 }

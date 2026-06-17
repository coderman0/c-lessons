////пишем конвертер валют
using System;

class Program
{
  static void Main()
  {

    
    Console.WriteLine("введите сумму в лирах");

    string amountText = Console.ReadLine();
    double amount = Convert.ToDouble(amountText);

    double exchangeRate = 0.023; //примерный курс лиры к доллару

     if (amount < 0)
    {
      Console.WriteLine("сумма не может быть отрицательной");
    }

    else {
      double dollars = amount * exchangeRate;

    Console.WriteLine(amount + " лир = " + dollars + " долларов ");
    }

    

   
    
     

;  }
}

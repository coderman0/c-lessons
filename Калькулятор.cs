using System;

class Program
{
  static void Main()
  {

    //// это будет бесконечный цикл потому что используем while (true), который будет выполняться, пока пользователь не закроет программу
    while (true)
    {
      Console.WriteLine("Выберите тип операции:  (+ - * /): ");
      String operation = Console.ReadLine();
      
      Console.Write("Введите первое число: ");
      int a = Convert.ToInt32(Console.ReadLine());

      Console.Write("Введите второе число: ");
      int b = Convert.ToInt32(Console.ReadLine());

      if (operation == "+"){
        Console.WriteLine(a + b);
      }
      else if (operation == "+")
      {
        Console.WriteLine(a - b);
      }
      else if (operation == "*")
      {
        Console.WriteLine(a * b);
      }
      else if (operation == "/")
      {
        Console.WriteLine(a / b );
      }
      else
      {
        Console.WriteLine("Неверный тип операции");
      }

      Console.WriteLine("Нажмите любую клавишу для продолжения...");
      Console.ReadKey();
      Console.Clear();

    }
  }
}

////конец 36:00

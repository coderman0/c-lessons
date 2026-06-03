using System;

class Program
{
    //тут вообще всё что есть цивры буквы и тд и тп
    static void Main()
    {
        int age = 25;
        double height = 1.75;
        string name = "david";
        bool isStudent = false;

        float floatHeight = 1.75f;


          ////тут печатаем значения переменных на экран
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Is student: " + isStudent);

          

          
          /// цифирки ///тут короче выдала ошибку 11:40 на видео https://www.youtube.com/watch?v=vSYxf97InfI&t=419s
        float floatNum = 10.5f;
        int intNum = (int)floatNum;
        Console.WriteLine(intNum);




        int num = 123;
        double decimalNum = num; 


         //конвертация типов 
        int boolInt = Convert.ToInt32(isStudent);  ///тут он короче конвертирует булевое значение в целое число (true будет 1, а false будет 0)
        Console.WriteLine(boolInt);


         //тут мы конвертировали age то есть int в string и вывели на экран
     string convertage = Convert.ToString(age);

     Console.WriteLine(convertage);

  
     //конец 15:50 видео https://www.youtube.com/watch?v=vSYxf97InfI&t=950s



    }
}

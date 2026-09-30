using System;

public class MainClass
{
    public static void Main()
    {
        int number = 0;                           //Переменная для счетчика, будет повышаться
        int maxNumber;                            //Максимальное число, до которого мы должны выводить квадраты
        string inputNumber = Console.ReadLine();
        int.TryParse(inputNumber, out maxNumber);

        while (number <= maxNumber)               //Сравниваем текущее число с максимальным 
        {
            Console.WriteLine(number * number);     //Выводим квадрат числа
            number++;                               //Увеличиваем число на 1
        }

        Console.WriteLine("Выполнение завершено!");
    }
}
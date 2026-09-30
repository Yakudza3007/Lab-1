using System;
using System.ComponentModel;
using System.Globalization;

namespace Lab_1;

public class Lab_1
{
    public static void Main()
    {
        Lab_1 lab = new Lab_1();
        Console.Write("Введите номер задачи: ");
        if (int.TryParse(Console.ReadLine(), out int numberTask))
        {
            switch (numberTask)
            {
                case 1:
                    int xOne;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(), out xOne))
                        {
                            break;
                        }
                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");

                    }
                    
                    int lastNums = lab.sumLastNums(xOne);
                    Console.WriteLine($"Сумма последних двух цифр введенного вами числа: {lastNums}");
                    break;

                case 2:
                    int xTwo;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(), out xTwo))
                        {
                            break;
                        }
                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");

                    }
                    
                    bool number = lab.isPositive(xTwo);
                    if (xTwo == 0)
                    {
                        Console.WriteLine("0 не является положительным или отрицательным числом!");
                    }
                    else if (number)
                    {
                        Console.WriteLine($"Число {xTwo} - положительное");
                    }
                    else
                    {
                        Console.WriteLine($"Число {xTwo} - отрицательное");
                    }
                    break;

                case 3:
                    char xThree;
                    while (true)
                    {
                        Console.Write("Введите букву латинского алфавита: ");
                        if (char.TryParse(Console.ReadLine(), out xThree))
                        {
                            break;
                        }
                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");

                    }
                    
                    bool upper = lab.isUpperCase(xThree);
                    if (upper)
                    {
                        Console.WriteLine("Вы ввели заглавную букву латинского алфавита");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели маленькую букву латинского алфавита");
                    }
                    break;

                case 4:
                    int variableOne;
                    while (true)
                    {
                        Console.Write("Введите число a: ");
                        if (int.TryParse(Console.ReadLine(), out variableOne))
                        {
                            break;
                        }
                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int variableTwo;
                    while (true)
                    {
                        Console.Write("Введите число b: ");
                        if (int.TryParse(Console.ReadLine(), out variableTwo))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }
                    
                    bool divisible = lab.isDivisor(variableOne, variableTwo);
                    if (divisible)
                    {
                        Console.WriteLine("Одно из чисел делится на другое нацело");
                    }
                    else
                    {
                        Console.WriteLine("Числа друг на друга не делятся");
                    }
                    break;

                case 5:
                    int preVariable;
                    while (true)
                    {
                        Console.Write($"Введите 1 переменную: ");
                        if (int.TryParse(Console.ReadLine(), out preVariable))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }
                
                    for (int i = 2; i < 6; i++)
                    {
                            int variable;
                            while (true)
                            {
                                Console.Write($"Введите {i} переменную: ");
                                if (int.TryParse(Console.ReadLine(),
                                        out variable))
                                {
                                    break;
                                }

                                Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                            }
                            
                            int sumNum = lab.lastNumSum(preVariable, variable);
                            preVariable = sumNum;
                    }
                    Console.Write($"Итоговая сумма:  {preVariable}");
                    break;

                case 6:
                    int variableThree;
                    while (true)
                    {
                        Console.Write("Введите число a: ");
                        if (int.TryParse(Console.ReadLine(),
                                out variableThree))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int variableFour;
                    while (true)
                    {
                        Console.Write("Введите число b: ");
                        if (int.TryParse(Console.ReadLine(), out variableFour))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    double lastNum = lab.safeDiv(variableThree, variableFour);
                    Console.WriteLine($"Результат деления: {lastNum}");
                    break;
                
                case 7:
                    int variableFive;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(), out variableFive))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int variableSix;
                    while (true)
                    {
                        Console.WriteLine("Введите число y: ");
                        if (int.TryParse(Console.ReadLine(), out variableSix))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }
                    
                    string make = lab.makeDecision(variableFive, variableSix);
                    Console.WriteLine($"Результат: {make}");
                    break;
                
                case 8:
                    int variableSeven;
                    while (true)
                    {
                        Console.Write("Введите x: ");
                        if (int.TryParse(Console.ReadLine(), out variableSeven))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int variableEight;
                    while (true)
                    {
                        Console.Write("Введите y: ");
                        if (int.TryParse(Console.ReadLine(), out variableEight))
                        {
                            break;
                        }
                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");

                    }

                    int variableNine;
                    while (true)
                    {
                        Console.Write("Введите z: ");
                        if (int.TryParse(Console.ReadLine(), out variableNine))
                        {
                            break;
                        }
                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }
                    
                    bool result = lab.sum3(variableSeven, variableEight, variableNine);
                    if (result == true)
                    {
                        Console.WriteLine("Два числа можно сложить так, чтобы получилось третье");
                    }
                    else
                    {
                        Console.WriteLine("Два числа нельзя сложить так, чтобы получилось третье");
                    }
                    break;
                
                case 9:
                    int variableEleven;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(), out variableEleven))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    string ageResult = lab.age(variableEleven);
                    Console.WriteLine($"Результат: {variableEleven} {ageResult}");
                    break;
                
                case 10:
                    Console.Write("Введите день недели: ");
                    string word = Console.ReadLine();
                    Console.WriteLine("Результат:");
                    lab.printDays(word);
                    break;
                
                case 11:
                    int variableTwelve;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(),
                                out variableTwelve))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    string resultNumber = lab.reverseListNums(variableTwelve);
                    Console.WriteLine($"Результат: {resultNumber}");
                    break;
                
                case 12:
                    int variableThirteen;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(),
                                out variableThirteen))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }
                    
                    int variableFourteen;
                    while (true)
                    {
                        Console.Write("Введите число y: ");
                        if (int.TryParse(Console.ReadLine(),
                                out variableFourteen))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }
                    
                    int resultDegree = lab.pow(variableThirteen, variableFourteen);
                    Console.WriteLine($"Результат: {resultDegree}");
                    break;
                
                case 13:
                    int variableFifteen;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(),
                                out variableFifteen))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    bool remainderNumber = lab.equalNum(variableFifteen);
                    if (remainderNumber == true)
                    {
                        Console.WriteLine("Число состоит из одинаковых цифр");
                    }
                    else
                    {
                        Console.WriteLine("Число не состоит из одинаковых цифр");
                    }
                    break;
                
                case 14:
                    int variableSixteen;
                    while (true)
                    {
                        Console.Write("Введите x: ");
                        if (int.TryParse(Console.ReadLine(), out variableSixteen))
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                        }
                    }
                    
                    lab.leftTriangle(variableSixteen);
                    break;
                
                case 15:
                    lab.guessGame();
                    break;

                case 16:
                    int findLastSize;
                    while (true)
                    {
                        Console.Write("Введите размер массива: ");
                        if (int.TryParse(Console.ReadLine(), out findLastSize))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int[] findLastArr = new int[findLastSize];
                    for (int i = 0; i < findLastSize; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Введите элемент {i}: ");
                            if (int.TryParse(Console.ReadLine(), out findLastArr[i]))
                            {
                                break;
                            }

                            Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                        }
                    }

                    int findLastX;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(), out findLastX))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int findLastResult = lab.findLast(findLastArr, findLastX);
                    Console.WriteLine($"Индекс последнего вхождения: {findLastResult}");
                    break;

                case 17:
                    int addSize;
                    while (true)
                    {
                        Console.Write("Введите размер массива: ");
                        if (int.TryParse(Console.ReadLine(), out addSize))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int[] addArr = new int[addSize];
                    for (int i = 0; i < addSize; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Введите элемент {i}: ");
                            if (int.TryParse(Console.ReadLine(), out addArr[i]))
                            {
                                break;
                            }

                            Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                        }
                    }

                    int addX;
                    while (true)
                    {
                        Console.Write("Введите число x: ");
                        if (int.TryParse(Console.ReadLine(), out addX))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int addPos;
                    while (true)
                    {
                        Console.Write("Введите позицию pos: ");
                        if (int.TryParse(Console.ReadLine(), out addPos))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int[] addResult = lab.add(addArr, addX, addPos);
                    Console.WriteLine($"Результат: {string.Join(" ", addResult)}");
                    break;

                case 18:
                    int reverseSize;
                    while (true)
                    {
                        Console.Write("Введите размер массива: ");
                        if (int.TryParse(Console.ReadLine(), out reverseSize))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int[] reverseArr = new int[reverseSize];
                    for (int i = 0; i < reverseSize; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Введите элемент {i}: ");
                            if (int.TryParse(Console.ReadLine(), out reverseArr[i]))
                            {
                                break;
                            }

                            Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                        }
                    }

                    lab.reverse(reverseArr);
                    Console.WriteLine($"Результат: {string.Join(" ", reverseArr)}");
                    break;

                case 19:
                    int concatSizeOne;
                    while (true)
                    {
                        Console.Write("Введите размер первого массива: ");
                        if (int.TryParse(Console.ReadLine(), out concatSizeOne))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int[] concatArrOne = new int[concatSizeOne];
                    for (int i = 0; i < concatSizeOne; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Введите элемент {i} первого массива: ");
                            if (int.TryParse(Console.ReadLine(), out concatArrOne[i]))
                            {
                                break;
                            }

                            Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                        }
                    }

                    int concatSizeTwo;
                    while (true)
                    {
                        Console.Write("Введите размер второго массива: ");
                        if (int.TryParse(Console.ReadLine(), out concatSizeTwo))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int[] concatArrTwo = new int[concatSizeTwo];
                    for (int i = 0; i < concatSizeTwo; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Введите элемент {i} второго массива: ");
                            if (int.TryParse(Console.ReadLine(), out concatArrTwo[i]))
                            {
                                break;
                            }

                            Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                        }
                    }

                    int[] concatResult = lab.concat(concatArrOne, concatArrTwo);
                    Console.WriteLine($"Результат: {string.Join(" ", concatResult)}");
                    break;

                case 20:
                    int deleteSize;
                    while (true)
                    {
                        Console.Write("Введите размер массива: ");
                        if (int.TryParse(Console.ReadLine(), out deleteSize))
                        {
                            break;
                        }

                        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                    }

                    int[] deleteArr = new int[deleteSize];
                    for (int i = 0; i < deleteSize; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Введите элемент {i}: ");
                            if (int.TryParse(Console.ReadLine(), out deleteArr[i]))
                            {
                                break;
                            }

                            Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
                        }
                    }

                    int[] deleteResult = lab.deleteNegative(deleteArr);
                    Console.WriteLine($"Результат: {string.Join(" ", deleteResult)}");
                    break;
                
                default:
                    Console.WriteLine("Нет задачи с таким номером");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }
    }

    public int sumLastNums(int x)
    {
        x = Math.Abs(x);
        int lastNumber = x % 10;
        int latestNumber = (x / 10) % 10;
        return lastNumber + latestNumber;
    }

    public bool isPositive(int x)
    {
        bool positiveNumber = x > 0;
        return positiveNumber;
    }

    public bool isUpperCase(char x)
    {
        bool upperCase = 'A' <= x && x <= 'Z';
        return upperCase;
    }

    public bool isDivisor(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return false;
        }
        else
        {
            bool divisor = a % b == 0 || b % a == 0;
            return divisor;
        }
    }

    public int lastNumSum(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        return (a % 10) + (b % 10);
    }

    public double safeDiv(int x, int y)
    {
        if (y == 0)
        {
            return y;
        }
        else
        {
            return ((double) x / y);
        }
    }

    public String makeDecision(int x, int y)
    {
        if (x == y)
        {
            return $"{x} == {y}";
        }
        
        else if (x > y)
        {
            return $"{x} > {y}";
        }

        else
        {
            return $"{x} < {y}";
        }
    }

    public bool sum3(int x, int y, int z)
    {
        if ((x + y == z) || (x + z == y) || (y + z == x))
        {
            return true;
        }

        else
        {
            return false;
        }
        
    }

    public String age(int x)
    {
        if (x % 10 == 1 && x != 11)
        {
            return "год";
        }
        
        else if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) && (x != 12 && x != 13 && x != 14))
        {
            return "года";
        }

        else
        {
            return "лет";
        }
    }

    public void printDays(String x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            
            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            
            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            
            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            
            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            
            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            
            default:
                Console.WriteLine("Это не день недели");
                break;
                
        }
    }

    public String reverseListNums(int x)
    {
        string stringNumber = "";
        
        if (x > 0)
        {
            for (int i = x; i >= 0; i--)
            {
                stringNumber = stringNumber + i + " ";
            }
            return stringNumber;
        }

        else
        {
            for (int i = x; i <= 0; i++)
            {
                stringNumber = stringNumber + i + " ";
            }
            return stringNumber;
        }
    }

    public int pow(int x, int y)
    {
        int degree = 1;
        for (int i = 1; i <= y; i++)
        {
            degree *= x;
        }
        return degree;
    }

    public bool equalNum(int x)
    {
        int remainder = x % 10;
        x = x / 10;
        while (x > 0)
        {
            if (x % 10 == remainder)
            {
                x = x / 10;
            }
            
            else
            { 
                return false;
            }
        }
        return true;
    }

    public void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            string triangle = "";
            for (int b = 1; b <= i; b++)
            {
                triangle += "*";
            }
            Console.WriteLine(triangle);
        }
    }
    
        public void guessGame()
    {
        Random rnd = new Random();
        int target = rnd.Next(0, 10);
        int attempts = 0;

        while (true)
        {
            attempts++;
            int guess;
            while (true)
            {
                Console.Write("Введите число от 0 до 9: ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    break;
                }

                Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
            }

            if (guess == target)
            {
                Console.WriteLine($"Вы угадали! Вы отгадали число за {attempts} попытки");
                break;
            }

            Console.WriteLine("Вы не угадали, введите число от 0 до 9");
        }
    }

    public int findLast(int[] arr, int x)
    {
        int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                index = i;
            }
        }
        return index;
    }

    public int[] add(int[] arr, int x, int pos)
    {
        int[] result = new int[arr.Length + 1];
        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }
        result[pos] = x;
        for (int i = pos; i < arr.Length; i++)
        {
            result[i + 1] = arr[i];
        }
        return result;
    }

    public void reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i]; 
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            result[arr1.Length + i] = arr2[i];
        }
        return result;
    }

    public int[] deleteNegative(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                result[index] = arr[i];
                index++;
            }
        }
        return result;
    }
}

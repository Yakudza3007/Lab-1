using System;

namespace Lab_1;

public partial class Lab_1
{
    public static void Main()
    {
        Lab_1 lab = new Lab_1();
        Console.Write("Введите номер задачи: ");
        if (int.TryParse(Console.ReadLine(),
                out int numberTask))
        {
            switch (numberTask)
            {
                case 1:
                    int xOne;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out xOne))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int lastNums =
                        lab.sumLastNums(xOne);
                    Console.WriteLine(
                        "Сумма последних двух цифр " +
                        "введенного вами числа: " +
                        $"{lastNums}");
                    break;

                case 2:
                    int xTwo;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out xTwo))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    bool number = lab.isPositive(xTwo);
                    if (xTwo == 0)
                    {
                        Console.WriteLine(
                            "0 не является " +
                            "положительным или " +
                            "отрицательным числом!");
                    }
                    else if (number)
                    {
                        Console.WriteLine(
                            $"Число {xTwo} - " +
                            $"положительное");
                    }
                    else
                    {
                        Console.WriteLine(
                            $"Число {xTwo} - " +
                            $"отрицательное");
                    }
                    break;

                case 3:
                    char xThree;
                    while (true)
                    {
                        Console.Write(
                            "Введите букву " +
                            "латинского алфавита: ");
                        if (char.TryParse(
                                Console.ReadLine(),
                                out xThree))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    bool upper = lab.isUpperCase(xThree);
                    if (upper)
                    {
                        Console.WriteLine(
                            "Вы ввели заглавную " +
                            "букву латинского " +
                            "алфавита");
                    }
                    else
                    {
                        Console.WriteLine(
                            "Вы ввели маленькую " +
                            "букву латинского " +
                            "алфавита");
                    }
                    break;

                case 4:
                    int variableOne;
                    while (true)
                    {
                        Console.Write(
                            "Введите число a: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableOne))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int variableTwo;
                    while (true)
                    {
                        Console.Write(
                            "Введите число b: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableTwo))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    bool divisible =
                        lab.isDivisor(variableOne,
                            variableTwo);
                    if (divisible)
                    {
                        Console.WriteLine(
                            "Одно из чисел " +
                            "делится на другое " +
                            "нацело");
                    }
                    else
                    {
                        Console.WriteLine(
                            "Числа друг на друга " +
                            "не делятся");
                    }
                    break;

                case 5:
                    int preVariable;
                    while (true)
                    {
                        Console.Write(
                            "Введите 1 переменную: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out preVariable))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    for (int i = 2; i < 6; i++)
                    {
                        int variable;
                        while (true)
                        {
                            Console.Write(
                                "Введите " +
                                $"{i} переменную: ");
                            if (int.TryParse(
                                    Console.ReadLine(),
                                    out variable))
                            {
                                break;
                            }
                            Console.WriteLine(
                                "Некорректный " +
                                "ввод, попробуйте " +
                                "ещё раз");
                        }

                        int sumNum = lab.lastNumSum(
                            preVariable, variable);
                        preVariable = sumNum;
                    }
                    Console.Write(
                        "Итоговая сумма:  " +
                        $"{preVariable}");
                    break;

                case 6:
                    int variableThree;
                    while (true)
                    {
                        Console.Write(
                            "Введите число a: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableThree))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int variableFour;
                    while (true)
                    {
                        Console.Write(
                            "Введите число b: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableFour))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    double lastNum = lab.safeDiv(
                        variableThree, variableFour);
                    Console.WriteLine(
                        "Результат деления: " +
                        $"{lastNum}");
                    break;

                case 7:
                    int variableFive;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableFive))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int variableSix;
                    while (true)
                    {
                        Console.Write(
                            "Введите число y: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableSix))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    string make = lab.makeDecision(
                        variableFive, variableSix);
                    Console.WriteLine(
                        $"Результат: {make}");
                    break;

                case 8:
                    int variableSeven;
                    while (true)
                    {
                        Console.Write("Введите x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableSeven))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int variableEight;
                    while (true)
                    {
                        Console.Write("Введите y: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableEight))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int variableNine;
                    while (true)
                    {
                        Console.Write("Введите z: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableNine))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    bool result = lab.sum3(
                        variableSeven,
                        variableEight,
                        variableNine);
                    if (result == true)
                    {
                        Console.WriteLine(
                            "Два числа можно " +
                            "сложить так, чтобы " +
                            "получилось третье");
                    }
                    else
                    {
                        Console.WriteLine(
                            "Два числа нельзя " +
                            "сложить так, чтобы " +
                            "получилось третье");
                    }
                    break;

                case 9:
                    int variableEleven;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableEleven))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    string ageResult =
                        lab.age(variableEleven);
                    Console.WriteLine(
                        "Результат: " +
                        $"{variableEleven} " +
                        $"{ageResult}");
                    break;

                case 10:
                    Console.Write(
                        "Введите день недели: ");
                    string word = Console.ReadLine();
                    Console.WriteLine("Результат:");
                    lab.printDays(word);
                    break;

                case 11:
                    int variableTwelve;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableTwelve))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    string resultNumber =
                        lab.reverseListNums(
                            variableTwelve);
                    Console.WriteLine(
                        "Результат: " +
                        $"{resultNumber}");
                    break;

                case 12:
                    int variableThirteen;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableThirteen))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int variableFourteen;
                    while (true)
                    {
                        Console.Write(
                            "Введите число y: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableFourteen))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int resultDegree = lab.pow(
                        variableThirteen,
                        variableFourteen);
                    Console.WriteLine(
                        "Результат: " +
                        $"{resultDegree}");
                    break;

                case 13:
                    int variableFifteen;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableFifteen))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    bool remainderNumber =
                        lab.equalNum(variableFifteen);
                    if (remainderNumber == true)
                    {
                        Console.WriteLine(
                            "Число состоит из " +
                            "одинаковых цифр");
                    }
                    else
                    {
                        Console.WriteLine(
                            "Число не состоит " +
                            "из одинаковых цифр");
                    }
                    break;

                case 14:
                    int variableSixteen;
                    while (true)
                    {
                        Console.Write("Введите x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out variableSixteen))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(
                                "Некорректный ввод, " +
                                "попробуйте ещё раз");
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
                        Console.Write(
                            "Введите размер массива: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out findLastSize))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int[] findLastArr =
                        new int[findLastSize];
                    for (int i = 0;
                         i < findLastSize; i++)
                    {
                        while (true)
                        {
                            Console.Write(
                                "Введите " +
                                $"элемент {i}: ");
                            if (int.TryParse(
                                    Console.ReadLine(),
                                    out findLastArr[i]))
                            {
                                break;
                            }
                            Console.WriteLine(
                                "Некорректный " +
                                "ввод, попробуйте " +
                                "ещё раз");
                        }
                    }

                    int findLastX;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out findLastX))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int findLastResult =
                        lab.findLast(findLastArr,
                            findLastX);
                    Console.WriteLine(
                        "Индекс последнего " +
                        $"вхождения: {findLastResult}");
                    break;

                case 17:
                    int addSize;
                    while (true)
                    {
                        Console.Write(
                            "Введите размер массива: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out addSize))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int[] addArr = new int[addSize];
                    for (int i = 0; i < addSize; i++)
                    {
                        while (true)
                        {
                            Console.Write(
                                "Введите " +
                                $"элемент {i}: ");
                            if (int.TryParse(
                                    Console.ReadLine(),
                                    out addArr[i]))
                            {
                                break;
                            }
                            Console.WriteLine(
                                "Некорректный " +
                                "ввод, попробуйте " +
                                "ещё раз");
                        }
                    }

                    int addX;
                    while (true)
                    {
                        Console.Write(
                            "Введите число x: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out addX))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int addPos;
                    while (true)
                    {
                        Console.Write(
                            "Введите позицию pos: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out addPos))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int[] addResult = lab.add(
                        addArr, addX, addPos);
                    Console.WriteLine(
                        "Результат: " +
                        $"{string.Join(" ", addResult)}");
                    break;

                case 18:
                    int reverseSize;
                    while (true)
                    {
                        Console.Write(
                            "Введите размер массива: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out reverseSize))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int[] reverseArr =
                        new int[reverseSize];
                    for (int i = 0;
                         i < reverseSize; i++)
                    {
                        while (true)
                        {
                            Console.Write(
                                "Введите " +
                                $"элемент {i}: ");
                            if (int.TryParse(
                                    Console.ReadLine(),
                                    out reverseArr[i]))
                            {
                                break;
                            }
                            Console.WriteLine(
                                "Некорректный " +
                                "ввод, попробуйте " +
                                "ещё раз");
                        }
                    }

                    lab.reverse(reverseArr);
                    Console.WriteLine(
                        "Результат: " +
                        $"{string.Join(" ", reverseArr)}");
                    break;

                case 19:
                    int concatSizeOne;
                    while (true)
                    {
                        Console.Write(
                            "Введите размер " +
                            "первого массива: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out concatSizeOne))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int[] concatArrOne =
                        new int[concatSizeOne];
                    for (int i = 0;
                         i < concatSizeOne; i++)
                    {
                        while (true)
                        {
                            Console.Write(
                                "Введите элемент " +
                                $"{i} первого массива: ");
                            if (int.TryParse(
                                    Console.ReadLine(),
                                    out concatArrOne[i]))
                            {
                                break;
                            }
                            Console.WriteLine(
                                "Некорректный " +
                                "ввод, попробуйте " +
                                "ещё раз");
                        }
                    }

                    int concatSizeTwo;
                    while (true)
                    {
                        Console.Write(
                            "Введите размер " +
                            "второго массива: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out concatSizeTwo))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int[] concatArrTwo =
                        new int[concatSizeTwo];
                    for (int i = 0;
                         i < concatSizeTwo; i++)
                    {
                        while (true)
                        {
                            Console.Write(
                                "Введите элемент " +
                                $"{i} второго массива: ");
                            if (int.TryParse(
                                    Console.ReadLine(),
                                    out concatArrTwo[i]))
                            {
                                break;
                            }
                            Console.WriteLine(
                                "Некорректный " +
                                "ввод, попробуйте " +
                                "ещё раз");
                        }
                    }

                    int[] concatResult = lab.concat(
                        concatArrOne, concatArrTwo);
                    Console.WriteLine(
                        "Результат: " +
                        $"{string.Join(" ", concatResult)}");
                    break;

                case 20:
                    int deleteSize;
                    while (true)
                    {
                        Console.Write(
                            "Введите размер массива: ");
                        if (int.TryParse(
                                Console.ReadLine(),
                                out deleteSize))
                        {
                            break;
                        }
                        Console.WriteLine(
                            "Некорректный ввод, " +
                            "попробуйте ещё раз");
                    }

                    int[] deleteArr = new int[deleteSize];
                    for (int i = 0;
                         i < deleteSize; i++)
                    {
                        while (true)
                        {
                            Console.Write(
                                "Введите " +
                                $"элемент {i}: ");
                            if (int.TryParse(
                                    Console.ReadLine(),
                                    out deleteArr[i]))
                            {
                                break;
                            }
                            Console.WriteLine(
                                "Некорректный " +
                                "ввод, попробуйте " +
                                "ещё раз");
                        }
                    }

                    int[] deleteResult =
                        lab.deleteNegative(deleteArr);
                    Console.WriteLine(
                        "Результат: " +
                        $"{string.Join(" ", deleteResult)}");
                    break;

                default:
                    Console.WriteLine(
                        "Нет задачи с таким номером");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }
    }
}

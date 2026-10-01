using System;

namespace Lab_1;

public partial class Lab_1
{
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
        if ((x + y == z) || (x + z == y)
            || (y + z == x))
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
        else if ((x % 10 == 2 || x % 10 == 3
                  || x % 10 == 4)
                 && (x != 12 && x != 13
                     && x != 14))
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
                Console.WriteLine(
                    "Это не день недели");
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
                stringNumber =
                    stringNumber + i + " ";
            }
            return stringNumber;
        }
        else
        {
            for (int i = x; i <= 0; i++)
            {
                stringNumber =
                    stringNumber + i + " ";
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
                Console.Write(
                    "Введите число от 0 до 9: ");
                if (int.TryParse(
                        Console.ReadLine(),
                        out guess))
                {
                    break;
                }
                Console.WriteLine(
                    "Некорректный ввод, " +
                    "попробуйте ещё раз");
            }

            if (guess == target)
            {
                Console.WriteLine(
                    "Вы угадали! Вы " +
                    "отгадали число за " +
                    $"{attempts} попытки");
                break;
            }

            Console.WriteLine(
                "Вы не угадали, введите " +
                "число от 0 до 9");
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
        int[] result =
            new int[arr.Length + 1];
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
        for (int i = 0;
             i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result =
            new int[arr1.Length + arr2.Length];
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
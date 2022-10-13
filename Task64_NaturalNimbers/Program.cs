// SЗадача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintIntegers(int num = 1)
{
    Console.WriteLine(num);
    if (num > 1)
    {
        PrintIntegers(--num);
    }
}

PrintIntegers(8);
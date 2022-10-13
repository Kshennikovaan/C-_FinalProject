// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120

int CalculateIntRange(int m, int n)
{
    if (m <= n)
    {
        return m + CalculateIntRange(++m, n);
    }
    else
    {
        return 0;
    }
}

int resultOfIntegersCalculation = CalculateIntRange(1, 15);
Console.WriteLine("Result Of Integers: {0}", resultOfIntegersCalculation);
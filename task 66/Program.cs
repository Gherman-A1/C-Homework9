// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

void PrintNumbers(int numA, int numB)
{
    if (numA <= numB)
    {
        Console.Write($"{numA} ");
        PrintNumbers(numA + 1, numB);
    }
}

int SumNumbersRecursive(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + SumNumbersRecursive(start + 1, end);
}

int numM = Prompt("Введите первое число: ");
int numN = Prompt("Введите второе число: ");
if (numM == numN) Console.WriteLine("Введенные числа равны");
else
{
    if (numM < numN)
    {
        PrintNumbers(numM, numN);
        Console.Write($"Сумма всех чисел в промежутке: {SumNumbersRecursive(numM, numN)}");
    }
    else
    {
        PrintNumbers(numN, numM);
        Console.WriteLine($"Сумма всех чисел в промежутке: {SumNumbersRecursive(numN, numM)}");
    }
}

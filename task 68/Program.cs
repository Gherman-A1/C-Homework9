// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int numM = Prompt("Введите первое неотрицательное целое число: ");
int numN = Prompt("Введите второе неотрицательное целое число: ");
int functionA = Ackermann(numM, numN);
Console.Write($"Значение функции Аккермана для введенных чисел: {functionA}");
//: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

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

int numM = Prompt("Введите первое число: ");
int numN = Prompt("Введите второе число: ");
if (numM == numN) Console.WriteLine("Введенные числа равны");
else
{
    if (numM < numN) PrintNumbers(numM, numN);
    else PrintNumbers(numN, numM);
}
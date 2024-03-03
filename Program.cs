// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите первое число: ");
    int N = ReadInt("Введите второе число: ");
    PrintNumbers(M, N);
}

void PrintNumbers(int M, int N)
{
    if (M > N) return;
    System.Console.Write(M + " ");
    PrintNumbers(M + 1, N);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

//void Main()
//{
//    int M = ReadInt("Введите первое число: ");
//    int N = ReadInt("Введите второе число: ");
//    PrintNumbers(M, N);
//}

//void PrintNumbers(int M, int N)
//{
//    if (M > N) return;
//    System.Console.Write(M + " ");
//    PrintNumbers(M + 1, N);
//}
//
//int ReadInt(string msg)
//{
//    System.Console.Write(msg);
//    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
//}
//
//Main();

// Задача 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//void Main()
//{
//    int M = ReadInt("Введите первое число: ");
//    int N = ReadInt("Введите второе число: ");
//    System.Console.Write(ackermann(M, N) + " ");
//}

//int ackermann(int m, int n)
//{
//    int resalt = 0;
//    return resalt = (m == 0) ?
//         n + 1 :
//         (m > 0 && n == 0) ?
//           ackermann(m - 1, 1) :
//           ackermann(m - 1, ackermann(m, n - 1));
//    }
//
//int ReadInt(string msg)
//{
//    System.Console.Write(msg);
//    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
//}

//Main();

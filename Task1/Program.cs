// Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void Main()
{
    int M = ReadInt("Введите первое число: ");
    int N = ReadInt("Введите второе число: ");

    PrintNumbers(M,N);
}

void PrintNumbers(int M, int N)
{
    if(N < M) return;
    PrintNumbers( M, N - 1);
    System.Console.Write(N + " ");
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

Main();
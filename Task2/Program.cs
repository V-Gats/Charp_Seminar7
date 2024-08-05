//  Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Введите первое число: ");
    int n = ReadInt("Введите второе число: ");

    System.Console.Write("Функция Аккермана равна: " + AkkermanFunction(m,n));
}

int AkkermanFunction(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return AkkermanFunction(m - 1, 1);
else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

Main();
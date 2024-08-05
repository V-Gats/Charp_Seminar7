//  Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 0, 30);
    PrintArray(array);
    reversArray(array, arraySize - 1);
}

void reversArray(int [] array, int arraySize)
{
    if (arraySize > 0)
    {
        System.Console.Write(array[arraySize] + " ");
        reversArray(array, arraySize - 1);
    }
    else System.Console.Write(array[0]);
}

void PrintArray(int[] arrayForPrint)
{
    for(int i = 0; i < arrayForPrint.Length; i++)
    System.Console.Write(arrayForPrint[i] + " ");

    System.Console.WriteLine();
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);

    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
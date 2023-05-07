// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int[,] CreateArray(int m, int n, int start, int finish)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random random = new Random();
            array[i, j] = random.Next(start, finish + 1);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i != array.GetLength(0) - 1) || (j != array.GetLength(1) - 1))
                Console.Write($"{array[i, j]}; ");
            else
                Console.WriteLine($"{array[i, j]}]");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива m= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива n= ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапозона start= ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание диапазона finish= ");
int finish = Convert.ToInt32(Console.ReadLine());
if (finish < start)
{
    int temp = finish;
    finish = start;
    start = temp;
}


int[,] arr = CreateArray(m, n, start, finish);
PrintArray(arr);

Console.Write("Введите индекс строки i= ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца j= ");
int j = Convert.ToInt32(Console.ReadLine());

if ((i-1) >= arr.GetLength(0) || (j-1) >= arr.GetLength(1))
{
    Console.WriteLine($"Элемента с индексом [{i},{j}] не существует");
}
else
{
    Console.WriteLine($"arr[{i},{j}]= {arr[i-1, j-1]}");
}
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] matrix, int minValue = 1, int maxValue = 9) // заполнение двумерного массива 
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] matrix) // печать двумерного массива 
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArrayOneSize(int[] matrix) // вывод массива на экран
{
    Console.WriteLine($"Вывод массива");
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]}\t ");
    }
    Console.Write($" ");
}

void Task54()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, 
    //которая упорядочит по убыванию элементы каждой строки двумерного массива.

    int rows = 3;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    int minValue = 0;
    int maxValue = 9;

    FillArray(matrix, minValue, maxValue);
    PrintArray(matrix);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int l = 0; l < columns - 1; l++)
            {
                if (matrix[i, l] < matrix[i, l + 1])
                {
                    int temp = matrix[i, l + 1];
                    matrix[i, l + 1] = matrix[i, l];
                    matrix[i, l] = temp;
                }
            }
        }
    }
    PrintArray(matrix);



}

void Task56()
{
    //  Задайте прямоугольный двумерный массив. 
    //  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    int rows = 2;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);

    int sumFirstColumns = 0;
    int sumSecondColumns = 0;

    for (int j = 0; j < columns; j++)
    {
        sumFirstColumns += matrix[0, j];
    }
    Console.WriteLine($"сумма первой строки {sumFirstColumns}");

    for (int j = 0; j < columns; j++)
    {
        sumSecondColumns += matrix[1, j];
    }
    Console.WriteLine($"сумма второй строки {sumSecondColumns}");

    if (sumFirstColumns < sumSecondColumns)
    {
        Console.WriteLine($"Первая строка с наименьшей суммой элементов");
    }
    else Console.WriteLine($"Вторая строка с наименьшей суммой элементов"); ;

}

void Task58()
{
    // Напишите программу, которая заполнит спирально массив 4 на 4.
    // Например, на выходе получается вот такой массив:
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07


    int rows = 4;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    FillArray(matrix, 1, 16);
    PrintArray(matrix);

    int step = 1;
    for (int j = 0; j < rows; j++)
    {
        matrix[0, j] = step;
        step++;
    //работает для первой строки
    }

    for (int j = 0; j < rows; j++)
    {
        matrix[1, 3] = step;   
        matrix[2, 3] = step+1;
        matrix[3, 3] = step+2;
    }

PrintArray(matrix);

}

Console.Clear();
Task58();
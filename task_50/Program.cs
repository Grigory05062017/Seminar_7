// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void InputArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(0, 10);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

Console.Clear();
Console.Write("Введите размеры матрицы: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);
Console.Write("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a > size[0] || b > size[1])
    {
    Console.Write("Такого числа нет");
    }
else
    {
     Console.Write($"Значение элемента равно {matrix [a-1,b-1]:F2}");
    }
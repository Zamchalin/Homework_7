// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет


void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 11); 
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}
Console.Clear();
int[,] matrix = new int[5,5];
InputMatrix(matrix);
Console.WriteLine("Введите строку:");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

if( pos1 > 4 || pos2 > 4)
        Console.WriteLine(" Такой позиции нет в матрице");
else
    Console.WriteLine($"Значение на этой позиции: {matrix[pos1, pos2]}");


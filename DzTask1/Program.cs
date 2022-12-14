// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void InputMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().NextDouble() * (10 + 0) - 0; 
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] matrix = new double[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
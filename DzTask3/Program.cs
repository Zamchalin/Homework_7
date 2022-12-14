// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
double resultat = 0;
for( int j = 0;j < matrix.GetLength(1); j++)
{
    
    for( int i = 0;i < matrix.GetLength(0); i++)
    {
    resultat = matrix[i,j] + resultat;
    }
    resultat = resultat / int.Parse(numbers[1]);
     Console.Write($"Среднее арифмитическое Столбца {j + 1}:  {resultat}, ");
    
}
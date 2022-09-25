// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int height = EnterInt ("Введите количество строк: ");
int width = EnterInt ("Введите количество столбцов: ");

double[ , ] numbers = new double [height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);

int EnterInt (string prompt)    // избежать дублирования кода 
{
    Console.Write (prompt);
    return int.Parse (Console.ReadLine()!);
}

void Fill2DArray(double[ , ] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = Math.Round(new Random().NextDouble() * 100, 2, MidpointRounding.AwayFromZero);
        }
    }
}

void Print2DArray(double[ , ] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)      // для каждой строки
    {
        for (int j = 0; j < width; j++)   // внутри этой строки для каждого столбца
        {
            Console.Write($"{numbers[i, j], 6} ");
        }
        Console.WriteLine();
    }
}
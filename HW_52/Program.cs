// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int height = EnterInt("Введите количество строк: ");
int width = EnterInt("Введите количество столбцов: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
ArithmeticMeanColumns(numbers, height, width);

int EnterInt(string prompt) // избежать дублирования кода 
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)      // для каждой строки
    {
        for (int j = 0; j < width; j++)   // внутри этой строки для каждого столбца
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }    
}

void ArithmeticMeanColumns(int[,] numbers, int height, int width)
{
    Console.WriteLine("\nСреднее арифметическое для каждого столбца: ");
    for (int j = 0; j < width; j++)
    {
        double sum = 0;             // ПОЧЕМУ sum имеет тип double, а не int??? Ведь складываем целые элементы!
        for (int i = 0; i < height; i++)
        {
            sum += numbers[i, j];
        }
        Console.Write($"{Math.Round((sum / height), 2, MidpointRounding.AwayFromZero),4} ");
    }
}
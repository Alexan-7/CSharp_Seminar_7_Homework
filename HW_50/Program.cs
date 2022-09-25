// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int height = EnterInt ("Введите количество строк: ");
int width = EnterInt ("Введите количество столбцов: ");

int[ , ] numbers = new int [height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
ItemByPosition(numbers, height, width);

int EnterInt (string prompt) // избежать дублирования кода 
{
    Console.Write (prompt);
    return int.Parse (Console.ReadLine()!);
}

void Fill2DArray(int[ , ] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random ().Next (-99, 100);
        }
    }
}

void Print2DArray(int[ , ] numbers, int height, int width)
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

int EnterPosition (string prompt) // избежать дублирования кода 
{
    Console.Write (prompt);
    return int.Parse (Console.ReadLine()!);
}

void ItemByPosition(int[ , ] numbers, int HeightIndex, int WidthIndex)
{
    HeightIndex = EnterPosition ("Укажите позиции элемента по горизонтали: ");
    WidthIndex = EnterPosition ("Укажите позиции элемента по вертикали: ");
    if (HeightIndex <= height && WidthIndex <= width)
        Console.WriteLine($"Элемент на этой позиции {numbers[HeightIndex - 1, WidthIndex - 1]}");
    else Console.WriteLine("Такого элемента не существует!");
}
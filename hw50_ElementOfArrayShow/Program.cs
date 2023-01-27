            // Программа принимает позицию элемента в двумерном массиве, выдаёт
            // значение элемента, либо указание что такого элемента нет

int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 100)
{
    int[,] array = new int[rows, columns];

    var rnd = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue +1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

int? ArrayElementShow(int[,] array, int[] position)
{
    int? element = null;
    int row = position[0] - 1, column = position[1] - 1;

    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
    {
        element = array[row, column];
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }

    return element;
}

int [] pos;
int? foundElement;
int[,] massive = CreateArray(5, 5);

Console.Write("Введите номер строки и номер столбца элемента массива через пробел: ");
pos = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

PrintArray(massive);
Console.WriteLine();
foundElement = ArrayElementShow(massive, pos);
if (foundElement != null) Console.WriteLine("Элемент на данной позиции = " + foundElement);
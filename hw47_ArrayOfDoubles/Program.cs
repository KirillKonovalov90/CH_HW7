            // Программа принимает размеры 2х мерного массива m и n,
            // и создаёт двумерный массив m*n заполненный случайными вещественными числами

double[,] CreateArrayDoubles(int rows, int columns, double minValue = -100, double maxValue = 100)
{
    double[,] array = new double[rows, columns];
    double randnew;

    var rnd = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            randnew = minValue + rnd.NextDouble() * (maxValue - minValue);
            array[i, j] = Math.Round(randnew, 2);
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


double[,] massive = CreateArrayDoubles(5, 5);

PrintArray(massive);
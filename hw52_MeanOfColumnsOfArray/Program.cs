            // Программа находит среднее арифметическое элементов в столбцах заданного массива

int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 10)
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

double[] MeanOfColumnsOfArray(int[,] array)
{
    double[] means = new double[array.GetLength(1)];
        
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
        }
        means[j] = Math.Round(summ / array.GetLength(0), 2);
    }
    return means;
}

int[] size;
int[,] massive;
double[] answer;

Console.Write("Введите желаемое количество строк и столбцов массива через пробел: ");
size = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

massive = CreateArray(size[0], size[1]);

PrintArray(massive);
Console.WriteLine();

answer = MeanOfColumnsOfArray(massive);

Console.WriteLine("Значения среднеарифметического по каждому столбцу: " + string.Join("; ", answer));
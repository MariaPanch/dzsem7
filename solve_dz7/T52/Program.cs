// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
ArrayToConsole(array);
for (int i=0;i<array.GetLength(1);i++)
{
    System.Console.WriteLine(Medium(GetCol(array,i)));
}

int [] GetCol(int[,] array, int Col)
{
    int[] buf = new int[array.GetLength(0)];
    for (int i=0;i<array.GetLength(0);i++)
    {
        buf[i] = array[i,Col]; 
    }
    return buf;
}
double Medium(int[] array)
{
    double Sum=0;
    for (int i=0;i<array.Length;i++)
    {
        Sum+=array[i];
    }
    return Sum/(double)array.Length;
}

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}

void ArrayToConsole(int [,] array)
{
    int [] buf = new int[array.GetLength(1)];
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            buf[j] = array[i,j];
        }
        System.Console.WriteLine("[{0}]", string.Join(", ", buf));
    }
}
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int m = 3;
int n=4;
double [,] array = new double [m,n];

FillArray(array);
ArrayToConsole(array);


void FillArray(double [,] array)
{
    Random rnd = new Random();
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = rnd.NextDouble()*20-10;
        }
    }
}

void ArrayToConsole(double [,] array)
{
    double [] buf = new double[array.GetLength(1)];
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            buf[j] = array[i,j];
        }
        System.Console.WriteLine("[{0}]", string.Join(", ", buf));
    }
}


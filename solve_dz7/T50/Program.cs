// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int m = 3;
int n = 4;
int[,] array = new int[m, n];
int indexM;
int indexN;
FillArray(array);
ArrayToConsole(array);
System.Console.WriteLine("введите позицию 1");
indexM = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("введите позицию 2");
indexN = Convert.ToInt32(System.Console.ReadLine());

if (indexM >= array.GetLength(0) || indexN >= array.GetLength(1))
{
    System.Console.WriteLine("Нет такого элемента");
}
else
{
    System.Console.WriteLine(array[indexM, indexN]);
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
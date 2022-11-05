// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int maxValuue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns;j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValuue + 1) + new Random().NextDouble(), 1);
    return array;
}

void Show2dArray (double[,]array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows;i++)

        for(int j = 0; j < columns;j++)
            array[i,j] = new Random().Next(min, max + 1);
        return array;

}

void Show2dArray (int[,]array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int PositionOfElement (int[,] array, int i,int j)
{

    while(i >= array.GetLength(0) && j >= array.GetLength(1))
    {
        Console.WriteLine("Error");
        Console.Write("Input your rows:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input your columns:");
        int columns = Convert.ToInt32(Console.ReadLine());
    }
    int sum = array[i,j];
    return sum;
}   


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.Write("Input your rows:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your columns:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{PositionOfElement(myArray,rows,columns)}");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows;i++)
        for(int j = 0; j < columns;j++)
            array[i,j] = new Random().Next(min, max + 1);
        return array;
            
}

void Show2dArray (int[,]array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[] MiddleSize(int[,]array)
{
    double sum = 0;
    double[] newArray = new double[array.GetLength(1)];
    for(int j = 0;j < array.GetLength(1);j++)
    {
        for(int i = 0; i <array.GetLength(0); i++)
        {
            sum+=array[i,j];
            newArray[j] = Math.Round(sum / array.GetLength(0),1);
        }
        sum = 0;
    }
    return newArray;
}

void ShowArray (double[] array)
{
    for(int i = 0; i < array.Length;i++)
    
        Console.Write(array[i] + " | ");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] newArray = MiddleSize(myArray);
Console.WriteLine("MiddleSize :");
ShowArray(newArray);


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int arraySizeFromUser(string message)
{
    Console.WriteLine(message);
    int numbersFromUser = Convert.ToInt32(Console.ReadLine());
    return numbersFromUser;
}

int[,] generateArray(int row, int col, int start, int stop)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(start, stop + 1);
        }
    }
    return array;
}

double[] arithmeticMeanOfArrayColumns(int[,] array)
{
    double[] arrayNew = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumNumberOfCol = 0;
        double meanSumNumberOfCol = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumNumberOfCol = sumNumberOfCol + array[i,j];
            meanSumNumberOfCol = sumNumberOfCol / array.GetLength(0);
        }
        
        arrayNew[j] = Math.Round(meanSumNumberOfCol, 1);
    }
    return arrayNew;
}

void printArray2(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
         if (i < array.Length - 1)
        {
            Console.Write(";" + "\t");
        }
    }
    Console.WriteLine();
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int row = arraySizeFromUser("Введите количество строк массива");
int col = arraySizeFromUser("Введите количество столбцов массива");
Console.WriteLine();
int[,] array = generateArray(row, col, 1, 10);
printArray(array);
Console.WriteLine();
double[] array2 = arithmeticMeanOfArrayColumns(array);
Console.WriteLine("Среднее арифметическое по столбцам равно:");
printArray2(array2);
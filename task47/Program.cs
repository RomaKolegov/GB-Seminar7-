/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int arraySizeFromUser(string message)
{
    Console.WriteLine(message);
    int numbersFromUser = Convert.ToInt32(Console.ReadLine());
    return numbersFromUser;
}

double[,] generateArray(int row, int col, int range)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(- range, range + 1));
        }
    }
    return array;
}
void printArray(double[,] array)
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
double[,] array = generateArray(row, col, 100);
printArray(array);
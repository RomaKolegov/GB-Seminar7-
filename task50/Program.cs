/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
9 -> 4
5 -> 9
*/
int positionNumber(string message)
{
    Console.WriteLine(message);
    int index = Convert.ToInt32(Console.ReadLine());
    return index;
}

int[,] generateArray(int row, int col, int range)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(- range, range + 1);
        }
    }
    return array;
}

void numberFromArray(int[,] array, int index)
{
    if (index <= (array.GetLength(0) * array.GetLength(1) - 1) && index >= 0)
        {
           int number = array[index / array.GetLength(1) , index % array.GetLength(1)];
            Console.WriteLine($"Под индексом {index} записано число {number}");
        }
    else
        {
            Console.WriteLine("Нет такой позиции в массиве");
        }
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
Console.WriteLine("Заданный массив:");
int[,] array = generateArray(4, 4, 5);
printArray(array);
int posNumber = positionNumber("Введите позицию массива");
numberFromArray(array, posNumber);

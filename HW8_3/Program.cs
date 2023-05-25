// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = {
                    { 2, 4 },
                    { 3, 2 }
                };

int[,] array2 = {
                    { 3, 4 },
                    { 3, 3 }
                };

int[,] arrayRezult = new int[2, 2];

arrayRezult[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
arrayRezult[0, 1] = array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 1];
arrayRezult[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 1] * array2[1, 0];
arrayRezult[1, 1] = array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1];

PrintArray(arrayRezult);


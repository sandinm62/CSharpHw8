// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] CreateArray(int[,,] array1)
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            for(int k = 0; k < array1.GetLength(2); k++)
            {
                array1[i, j, k] = new Random().Next(10, 100);
            }
        }
    }

    return array1;
}


void PrintArray(int[,,] arrayPrint)
{
    for(int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for(int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            for(int k = 0; k < arrayPrint.GetLength(2); k++)
            {
                Console.Write($" {arrayPrint[i, j, k]} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}


int[,,] array = new int[2, 2, 2];
CreateArray(array);
PrintArray(array);




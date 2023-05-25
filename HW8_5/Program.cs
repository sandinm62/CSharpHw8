// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateArray(int[,] array1)
{
    
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            array1[0, j] = new Random().Next(0, 10);                                                                                                                                                                                                                                                                                                                                                        
        }
        for (int i = 1; i < array1.GetLength(0); i++)
        {
            array1[i, 3] = new Random().Next(0, 10);
        }
        for (int j = 3; j > 0; j--)
        {
            array1[3, j] = new Random().Next(0, 10);
        }

        for (int i = 2; i > 0; i--)
        {
            array1[i, 0] = new Random().Next(0, 10);
        }
        for (int j = 1; j < 3; j++)
        {
            array1[1, j] = new Random().Next(0, 10);
        }
        array1[2, 2] = new Random().Next(0, 10);
        array1[2, 1] = new Random().Next(0, 10);
    
    return array1;
}

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



int[,] array = new int[4,4];
CreateArray(array);
PrintArray(array);




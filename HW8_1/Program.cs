// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateArray(int[,] array1)
{
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(0, 10);
        }
    }

    return array1;
}

void PrintArray(int[,] arrayPrint)
{
    for(int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for(int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write(arrayPrint[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] arraySort)
{
    //int[,] arrayNewSort = arraySort;
    for (int i = 0; i < arraySort.GetLength(0); i++)
    {
        for (int j = 0; j < arraySort.GetLength(1)-1; j++)
        {    
            int max = arraySort[i, j];
            int temp = j;  

                for ( int count = j; count < arraySort.GetLength(1)-1; count++)
                {                   
                    if (max < arraySort[i, count + 1])
                    {   
                        max = arraySort[i, count + 1];
                        temp = count + 1;

                    }                
                    
                }

            arraySort[i, temp] = arraySort[i,j];
            arraySort[i, j] = max;      
            
        }
       // Console.WriteLine();
    }
    return arraySort;
}


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колиичество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

CreateArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine("-------------");
PrintArray(array);
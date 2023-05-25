﻿// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSum(int[,] array1)
{   
    
    int min = 0;
    int temp = 0;
    
    for (int m = 0; m <= 0; m++)                        //цикл для присвоения минимального значения которое будет равно сумме элементов первой строки
    {
        for(int n = 0; n < array1.GetLength(1); n++)
        {   
            int sum = 0;
            sum = sum + array1[m , n ];
            min = sum;
        }
    }

    for(int i = 1; i < array1.GetLength(0); i++)        // циклы для сравнения суммы строк
    {   
        int sum = 0;
        
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            
            sum = sum + array1[i, j];
            
            if (min > sum)
            {
                min = sum;
                temp = i;
            }
        }
        sum = 0;                                        // обнуляем переменную sum для того чтобы можно было повторно посчитать сумму для другой строки
    }
    Console.WriteLine($"{temp + 1} строка с наименьшей суммой");
}



int[,] array = { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7} };

MinSum(array);

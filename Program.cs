// SЗадача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк массива: ");
// int rows=int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0 , 9);
// PrintArray(array);
// int[,]array2= ChangeArray(array);

// System.Console.WriteLine();
// PrintArray(array2);



// int[,] GetArray(int rows, int columns, int minValue=0, int maxValue=100)
// {
//     int[,] result = new int[rows,columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeArray(int[,] array2)
// {
//     for (int i = 0; i < rows; i++)
//     {
//        for (int j = 0; j < columns-1; j++)
//        {
//             if (array2[i, j] < array2[i, j+1])
//             {
//                 int temp = 0;
//                 temp = array2[i, j];
//                 array2[i, j] = array2[i, j+1];
//                 array2[i, j+1] = temp;
//             }
//        }
//     }
//     return array2;
// }



//Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Clear();

// int MinSum (int[,] array)
// {
//     int minSum = int.MaxValue;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int  sum =0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         if (sum < minSum)
//         minSum = sum;
//     }
//     return minSum;
// }

// void PrintArray(int[,] array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int rows = InputNumbers("Введите число строк 1-й матрицы: ");
// int columns = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int doubleColumns = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int Random = InputNumbers("Введите диапазон случайных чисел, заполняющих матрицы: от 1 до ");

// int[,] firstMartrix = new int[rows, columns];
// GetArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[columns, doubleColumns];
// GetArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[rows, doubleColumns];

// ProduktMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// PrintArray(resultMatrix);

// void ProduktMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void GetArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(Random);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] array = new int[2, 2, 2];
// GetArray(array);
// PrintArray(array);

// void GetArray(int[,,] array) 
// {
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[k, i, j] += count;
//                 count += 2;
//             }
//         }
//     }
// }
// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Array = new int[4, 4]; 


int number = 1; 
int i = 0;
int j = 0;

while (number <= Array.GetLength(0) * Array.GetLength(1)) 
{
  Array[i, j] = number;
  number++;
  if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Array.GetLength(1) - 1)
    j--;
  else
    i--;
}
PrintArray(Array);

void PrintArray(int[,] GetArray)
{
    for (int i = 0; i < GetArray.GetLength(0); i++)
    {
        for (int j = 0; j < GetArray.GetLength(1); j++)
        {
            Console.Write($"{GetArray[i, j]:D2}"+" ");
        }
        Console.WriteLine("");
    }
}
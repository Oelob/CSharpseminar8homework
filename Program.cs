Console.Clear();
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


// // Создаем функцию формирования двумерного целочисленного массива

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// // Создаем функцию вывода массива на экран

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{(array[i, j]),4}");
//         }
//         Console.WriteLine();

//     }
//     Console.WriteLine("--------------------------");
//     Console.WriteLine();
// }

// // Ввод данных 

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine());

// int[,] mass = GetArray(m, n, min, max);
// PrintArray(mass);

// // Упорядочивание массива и вывод результата на экран

// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0; j < mass.GetLength(1) - 1; j++)
//     {
//         int maxPosition = j;
//         for (int k = j+1; k < mass.GetLength(1); k++)
//         {
//             if (mass[i,k] > mass[i,maxPosition]) maxPosition = k;

//         }
//         int temp = mass[i,j];
//         mass[i,j] = mass[i,maxPosition];
//         mass[i,maxPosition] = temp;
//     }
// }
// PrintArray(mass);


/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// // Создаем функцию формирования двумерного целочисленного массива

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];

//     for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 result[i, j] = new Random().Next(min, max);
//             }
//         }
//     return result;      
// }

// // Создаем функцию вывода массива на экран

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{(array[i, j]),4}");
//         }
//         Console.WriteLine();

//     }
//     Console.WriteLine("--------------------------");
//     Console.WriteLine();
// }

// // Находим строку с наименьшей суммой элементов
// void MinSumElement(int[,]array)
// {

//     int[] sum = new int [array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int index = i;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] += array[i,j];
//         }

//     }

//     int result = 0;
//     for (int i = 0; i < sum.Length-1; i++)
//     {
//         int minIndex = i;
//         for (int j = 1; j < sum.Length; j++)
//         {
//             if (sum[j] < sum[minIndex]) minIndex = j;
//         }
//         result = minIndex+1;
//     }
//     Console.Write($"Строка с минимальным занчением {result}");
// }    

// // Ввод данных 
// int m = 0;
// int n = 0;
// do
// {
//     Console.Write("Введите количество строк массива: ");
//     m = int.Parse(Console.ReadLine());
//     Console.Write("Введите количество столбцов массива: ");
//     n = int.Parse(Console.ReadLine()); 
//     if (m==n) 
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine("Количество строк не должно быть равным количеству столбцов \nВведите данные еще раз:");
//         Console.ResetColor();
//     }
// } 
// while (m==n);

// Console.Write("Введите минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine());

// // Вывод данных

// int[,] mass = GetArray(m, n, min, max);
// PrintArray(mass);
// MinSumElement(mass);

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// // Создаем функцию формирования двумерного целочисленного массива

// int[,] GetArray(int rows, int columns, int min, int max)
// {
//     int[,] result = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 result[i, j] = new Random().Next(min, max);
//             }
//         }
//     return result;      
// }


// // Создаем функцию вывода массива на экран

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{(array[i, j]),4}");
//         }
//         Console.WriteLine();

//     }
//     Console.WriteLine("--------------------------");
//     Console.WriteLine();
// }

// int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
// {
//     int[,] result = new int [array1.GetLength(0),array2.GetLength(1)];

//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < array2.GetLength(0); k++)
//             {
//                 sum += array1[i,k]*array2[k,j];
//             }
//             result[i,j] = sum;
//         }
//     }

//     return result;
// }

// // Ввод данных 
// int rows1 = 0;
// int rows2 = 0;
// int columns1 = 0;
// int columns2 = 0;

// Console.Write("Введите количество строк первого массива: ");
// rows1 = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов первого массива: ");
// columns1 = int.Parse(Console.ReadLine());
// do
// {
// Console.Write("Введите количество строк второго массива: ");
// rows2 = int.Parse(Console.ReadLine());
// if (columns1 != rows2)
// {
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine("Количество столбцов первого массива должно ровняться количеству строк второго массива \nВведите данные еще раз:");
//     Console.ResetColor();
// }

// }
// while (columns1 != rows2);
// Console.Write("Введите количество столбцов второго массива: ");
// columns2 = int.Parse(Console.ReadLine());
// Console.Write("Введите минимальное значение первого массива: ");
// int min1 = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное значение первого массива: ");
// int max1 = int.Parse(Console.ReadLine());

// Console.Write("Введите минимальное значение второго массива: ");
// int min2 = int.Parse(Console.ReadLine());
// Console.Write("Введите максимальное значение второго массива: ");
// int max2 = int.Parse(Console.ReadLine());

// // Вывод массивов и произведения двух матриц

// int[,] matrix1 = GetArray(rows1,columns1,min1,max1);
// int[,] matrix2 = GetArray(rows2,columns2,min2,max2);


// PrintArray(matrix1); PrintArray(matrix2);

// PrintArray(MultiplicationMatrix(matrix1,matrix2));

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] GetArray(int pages, int rows, int columns)
        {
            int[,,] result = new int[pages, rows, columns];
            int[] check = new int [8];
        
            for (int i = 0; i < pages; i++)
            {
                for (int j = 0; j < rows; j++)
                {   
                    for (int k = 0; k < columns; k++)
                    {               
                        
                        result[i, j, k] = new Random().Next(10, 100);
                        there:
                        for (int z = 0; z < check.Length; z++)
                        {
                            if (result[i,j,k]==check[z])
                            {
                                result[i,j,k] = new Random().Next(10, 100);
                                goto there;
                            } 
                            
                            
                        }
                        for (int z = 0; z < check.Length; z++)
                        {
                            
                            if (result[i,j,k]!=check[z] && check[z]==0) check[z]=result[i,j,k];
                            
                            if (result[i,j,k]!=check[z]) 
                            {
                                
                                while (check[z]!=0)
                                {
                                    z++;
                                } 
                                check[z]=result[i,j,k];
                            } break;
                        }    
                        
                
                        
                    }
                }
            }
            return result;
        }

        void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Страница {i+1}");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{(array[i, j, k]),4} ({i},{j},{k})");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }
        PrintArray(GetArray(2,2,2));


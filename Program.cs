void Table()
{
string[,] table = new string [2, 5];
table[1, 2] = "Не будем маргиналами";

for (int rows = 0; rows < 2; rows++)
    {
        for (int columns = 0; columns < 5; columns++)
        {
            Console.WriteLine($"-{table[rows, columns]}-");
        }
        
    }
}

void Zadacha()
{
int[,] matrix = new int [3, 4];

void PrintArray(int[,] matr)
    {
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
        Console.WriteLine();
        }
    }

void FillArray(int[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1,10);
            }
        }
    }
}

//Table();
//PrintArray(matrix);
//FillArray(matrix);
//Zadacha();





void Zadacha47()
{

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    Console.Write("Укажите высоту массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите длину массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    double[,] matrix = new double [m, n];
    FillArrayDouble(matrix);
    PrintArrayDouble(matrix);   

}

void FillArrayDouble(double[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10) + Math.Round((rand.NextDouble()/100), 2);;
        }
    }
}

void PrintArrayDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}" + "\t" );
            }
        Console.WriteLine();
        }
}
    


void Zadacha50()
{

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

    Console.Write("Укажите номер столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите номер строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    Random rand = new Random();    
    int line = new Random().Next(5,10);
    int column = new Random().Next(5,10);
    int[,] matrix = new int [line, column];

    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    SearchElement(matrix, m, n, line, column);

}

void FillArrayInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArrayInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t" );
        }
    Console.WriteLine();
    }
}

void SearchElement(int[,] matrix, int m, int n, int column, int line)
{
    if (m < column && m >= 0 && n < line && n >= 0 )
    {
        Console.WriteLine("По заданным координатам находится элемент: " + matrix[n, m]);
    }
        
    else Console.WriteLine("Такого элемента нет");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Random rand = new Random();    
    int line = new Random().Next(5,10);
    int column = new Random().Next(5,10);
    int[,] matrix = new int [line, column];
   
    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    
    double sum = 0;
    int j = matrix.GetLength(1)-1;
    int temp = matrix.GetLength(0);
    int average;

    while (j >= 0)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {       
            average = matrix[i, j];
            sum = sum + average;        
        }
        Console.WriteLine($"Среднее арифметическое элементов столбца {j} равно: " + (sum/temp));
        j--;
        sum = 0;
    }
}

//Zadacha47();
//Zadacha50();
Zadacha52();
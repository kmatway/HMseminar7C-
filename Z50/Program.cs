// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetArray(int m,int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for(int i=0;i< inArray.GetLength(0); i++)
    {

         for(int j=0; j< inArray.GetLength(1); j++)
         {
            Console.Write($" {inArray[i,j]} ");
         }
        Console.WriteLine();
    }

}

void GetArraySearchElement(int[,] inArray, int x, int y)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
           if(i == x & j == y) Console.WriteLine(inArray[i,j]);
           
        }
    }
    if(x>inArray.GetLength(0) || y>inArray.GetLength(1)) Console.WriteLine("нет");
}   

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows,colums,0,10);
PrintArray(array);

Console.Write("Введите значение индекса элемента по строке: ");
int elX = int.Parse(Console.ReadLine());

Console.Write("Введите значение индекса элемента по столбцу: ");
int elY = int.Parse(Console.ReadLine());

GetArraySearchElement(array,elX,elY);

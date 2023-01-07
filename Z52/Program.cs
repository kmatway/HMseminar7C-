// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

void ArrayAverage(int[,] inArray)
{
    for(int j=0;j< inArray.GetLength(1); j++)
    {
         double avarage = 0;
         for(int i=0; i< inArray.GetLength(0); i++)
         {
            avarage = avarage + inArray[i,j];
         }
         avarage = avarage / inArray.GetLength(0);
        Console.WriteLine(avarage);
    }
    Console.WriteLine();
}

int [,] array = GetArray(3,4,0,10);
PrintArray(array);
ArrayAverage(array);



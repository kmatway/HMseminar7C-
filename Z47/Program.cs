// Задача 47: Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

double[,] GetArray(int m,int n)
{
    double[,] result = new double[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().NextDouble();
        }
    }
    return result;
}


void PrintArray(double[,] inArray)
{
    for(int i=0;i< inArray.GetLength(0); i++)
    {

         for(int j=0; j< inArray.GetLength(1); j++)
         {
            Console.Write($" {Math.Round(inArray[i,j],2)} ");
         }
        Console.WriteLine();
    }

}


double[,] array = GetArray(3,3);
PrintArray(array);




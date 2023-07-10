/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int ReadInt(string message){
    System.Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

double [,] GenerateArray(int col,int row){

    double[,] array = new double[col,row];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0);i++){
        for (int j = 0; j < array.GetLength(1);j++){
        array[i,j] = Math.Round(random.NextDouble()* 100,2);
        }
    }
    return array;
}

void  PrintArray(double[,] arr4print){
         for (int i = 0; i < arr4print.GetLength(0);i++){
        for (int j = 0; j < arr4print.GetLength(1);j++){
            System.Console.Write(arr4print[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк");
int cols = ReadInt("Введите количество столбцов");

PrintArray(GenerateArray(rows,cols));
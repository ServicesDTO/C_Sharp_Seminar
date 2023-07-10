/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int ReadInt(string message){
    System.Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GenerateArray(int col,int row, int minValue, int maxValue ){

    int[,] array = new int[col,row];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0);i++){
        for (int j = 0; j < array.GetLength(1);j++){
        array[i,j] = random.Next(minValue,maxValue+1);
        }
    }
    return array;
    }
    


void  PrintArray(int[,] arr4print){
         for (int i = 0; i < arr4print.GetLength(0);i++){
        for (int j = 0; j < arr4print.GetLength(1);j++){
            
            System.Console.Write(arr4print[i,j]+"\t");
            
        }
        System.Console.WriteLine();
    }
}

void  FindAverage(int[,] array){

    double[]  result = new double[array.GetLength(1)] ;
    double sum = 0;
        for (int j = 0; j < array.GetLength(1);j++){
        for (int i = 0; i < array.GetLength(0);i++){
            sum += array[i,j];
        }
        result[j] = sum/array.GetLength(0);
        sum = 0;
     }
        System.Console.WriteLine("--------");
     foreach(double i in result){
        System.Console.Write(i+"\t");
     }
    }



int[,] tempArray = GenerateArray(5,5,0,30);
PrintArray(tempArray);
FindAverage(tempArray);


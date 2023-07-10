/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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

void  FindPosition(int[,] array, int searchValue){

    bool found = false;
        for (int i = 0; i < array.GetLength(0);i++){
        for (int j = 0; j < array.GetLength(1);j++){
            if (array[i,j]== searchValue ){
            System.Console.WriteLine("Позиция элемента (" + i + "," + j +")");
            found = true;
            break;
            }
        }
     }
    if (!found){System.Console.WriteLine("Число не найдено!");}
}

int inputValue = ReadInt("Введите число ");
int[,] tempArray = GenerateArray(5,5,0,30);
PrintArray(tempArray);
FindPosition(tempArray,inputValue);


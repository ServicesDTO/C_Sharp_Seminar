// See https://aka.ms/new-console-template for more information
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GenerateArray(int Lenght, int minValue, int maxValue ){

    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght;i++){
    
        array[i] = random.Next(minValue,maxValue);
        System.Console.WriteLine(array[i]);
    }
    return array;
}

int OddQuantity(int[] inputArray){
    int quantity = 0;
    for (int i = 0; i < inputArray.Length; i++ ){
        if (inputArray[i]%2 == 0) {
            quantity++;
        }
        else{
            continue;
        }
     }
     return quantity;
}

System.Console.WriteLine(OddQuantity(GenerateArray(5,100,999)));
// See https://aka.ms/new-console-template for more information
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int[] GenerateArray(int Lenght, int minValue, int maxValue ){

    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght;i++){
    
        array[i] = random.Next(minValue,maxValue);
        System.Console.WriteLine(array[i]);
    }
    return array;
}

int Summ(int[] inputArray){
    int total = 0;
      for (int i = 0; i < inputArray.Length; i++ ){
        if (i%2 != 0) {
            total = total + inputArray[i];
        }
   }
     return total;
}

System.Console.WriteLine("Сумма нечетных ячеек = " + Summ(GenerateArray(5,0,10)));
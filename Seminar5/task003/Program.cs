/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double [] GenerateArray(int Lenght){

    double[] array = new double[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght;i++){
    
        array[i] = Math.Round(random.NextDouble()* 100,2);
        System.Console.WriteLine(array[i]);
    }
    return array;
}



double minValue(double[] array){
 double min = array[0] ;
for (int i = 0;i< array.Length;i++){
    if(min > array[i])
    {
        min = array[i];
    }
    
}
System.Console.WriteLine("min: " + min);
return min;

}

double maxValue(double[] array){
double max = array[0] ;
for (int i = 0;i< array.Length;i++){
    if(max < array[i])
    {
        max = array[i];
    }

}
System.Console.WriteLine("max: " + max);
return max;
}

double[] targetArray = GenerateArray(10);
double result = Math.Round(maxValue(targetArray) - minValue(targetArray),2);

System.Console.WriteLine("Разница между минимальным и максимальным числом: " + result);
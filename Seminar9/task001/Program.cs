/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int sum = 0;

int ReadInt(string message){
    System.Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}



void FindSum(int firstValue,int secondValue){
    
    if ( firstValue ==  secondValue){
        System.Console.WriteLine("значение равны");
        sum = sum + firstValue;
        return;}
        sum = sum + firstValue;
     FindSum(firstValue + 1,secondValue)  ;
    return;
    
}

int M = ReadInt("Введите первое число ");
int N = ReadInt("Введите первое число ");

FindSum(M,N);
System.Console.WriteLine("Сумма чисел от "+ M + " до " + N + " = "+ sum);



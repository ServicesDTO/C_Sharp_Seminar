// See https://aka.ms/new-console-template for more information
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.WriteLine("Введите любые числа через запятую");
string input = Console.ReadLine();

int[] ConvertToArray(string inputStr){

    int[] intArray =  Array.ConvertAll(input.Split(','), int.Parse);
    return intArray;
}

void CountPositivValues(int[] inputArray)
{
int result = 0 ;
foreach (int i in ConvertToArray(input)){
    if (i>0){
        result++;
    }
}
    System.Console.WriteLine("Количесво чисел  > 0 равно " + result);
}

CountPositivValues(ConvertToArray(input));
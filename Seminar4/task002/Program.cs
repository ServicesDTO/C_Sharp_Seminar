// See https://aka.ms/new-console-template for more information
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int summ(int[] x){
int res = 0;
for (int i = 0; i < x.Length; i++)
    {
        res = res + x[i];
    }
        return res;
}

Console.WriteLine("Введите число");
string  a = Console.ReadLine();
int[] b  = a.Select(c => Convert.ToInt32(c.ToString())).ToArray();
Console.WriteLine(summ(b));




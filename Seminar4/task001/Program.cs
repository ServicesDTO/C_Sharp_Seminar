// See https://aka.ms/new-console-template for more information
/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */


int pow(int x,int y) {
int res = 1;
 
for (int i = 1 ;i <= y ; i++ )
{
    res = res * x ; 
       
}
return res;

}
 
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(pow(a,b));
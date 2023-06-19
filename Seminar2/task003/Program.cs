// See https://aka.ms/new-console-template for more information
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int a ;
  
void validate (int  num )
    {
    if (num < 1 || num > 7)
        {
        Console.WriteLine("Введенное число не попадает в  диапозон от 1 до 7 "); 
        }
    else if (num >=6)
        {
        Console.WriteLine("Сегодня Выходной! ");
        }
    else
        {
        Console.WriteLine("Сегодня рабочий день! ");
        }    
        }

    Console.WriteLine("введите число обозначающее день недели от 1 до 7 ");

    a = Convert.ToInt32(Console.ReadLine());

    validate(a);







// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int  a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе  число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье  число");
int d = Convert.ToInt32(Console.ReadLine());


if (a > b && a > d ) {

Console.WriteLine( "Число " + a + " больше числа " + b + " и числа " + d);
}
else if (b > a &&  b > d )
{
    Console.WriteLine( "Число " + b + " больше числа " + a + " и числа " + d);
}
else 
{
    Console.WriteLine( "Число " + d + " больше числа " + a + " и числа " + b);
}



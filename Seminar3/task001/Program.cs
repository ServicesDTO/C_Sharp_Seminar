// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int a;


 String  IsPalindrome(int x ){
    int revertedNumber = 0;
    while(x > revertedNumber)
    {
        revertedNumber = revertedNumber * 10 + x % 10;
        x /= 10;
    }
    if(x == revertedNumber || x == revertedNumber/10)
    {
        return "Является!";
    }
    else 
    {
        return "Не является!";
    }
}

while (true){
    
  Console.WriteLine("введите трехзначное число ");  
  a = Convert.ToInt32(Console.ReadLine());
  if (a >= 10000 && a <= 99999 ){ 
    System.Console.WriteLine(IsPalindrome(a));
  }
}

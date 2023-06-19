// See https://aka.ms/new-console-template for more information

int a ;
string result;

void res (int  num , int pos){
result = num.ToString();
Console.WriteLine( result[pos]);
}

while (true){
    
  Console.WriteLine("введите трехзначное число ");  
  a = Convert.ToInt32(Console.ReadLine());
  if (a > 99 && a < 1000)
  {
    res(a,1);
    break;
  }
  else 
  {
    continue;
  }
}



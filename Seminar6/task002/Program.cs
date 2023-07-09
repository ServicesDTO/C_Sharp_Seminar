 /*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Введите значения переменных (b1 , k1 , b2 , k2) - через запятую");
string input = Console.ReadLine();

double[] ConvertToArray(string inputStr){

    double[] intArray =  Array.ConvertAll(input.Split(','), double.Parse);
    foreach(double i in intArray){
        System.Console.WriteLine( i);
    }
    return intArray;
}

void FindCoordinates(double[] inputValues){

    double xCoordinate = 0.0;
    double yCoordinate = 0.0;
     //k1 * x + b1 =  k2 * x + b2 -> k1x - k2x = b2 - b1 -> x(k1 -k2)= b2 -b1 -> x=(b2-b1)/k1-k2
     xCoordinate = Math.Round((inputValues[2] - inputValues[0] / inputValues[1] - inputValues[3]),2);
     yCoordinate = Math.Round((inputValues[1] * xCoordinate + inputValues[0]),2);
     System.Console.WriteLine(" точка пересечения двух прямых ("+ xCoordinate +","+ yCoordinate+")");
}
FindCoordinates(ConvertToArray(input));




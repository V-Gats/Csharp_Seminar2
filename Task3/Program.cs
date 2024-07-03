// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

System.Console.Write("Введите целое число в отрезке от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9 && number < 100)
{
    int n1 = number / 10;
    int n2 = number % 10;
    if (n1 > n2)
    System.Console.WriteLine("Наибольшая цифра: " + n1);
    else 
    System.Console.WriteLine("Наибольшая цифра: " + n2);
}
else
{
    System.Console.WriteLine("Число выходит за рамки отрезка");
}
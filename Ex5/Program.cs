// See https://aka.ms/new-console-template for more information
// Напишите программу 
Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int digit = number % 10;
System.Console.WriteLine($"Последняя цифра числа {number} равна {digit}");

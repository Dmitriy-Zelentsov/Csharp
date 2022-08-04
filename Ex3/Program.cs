// Напишите программу которая будет выдавать название для недели по заланному номеру
Console.WriteLine("Введите число от 1 до 7");
int numbers = Convert.ToInt32(Console.ReadLine());
if(numbers == 1) 
Console.WriteLine("Пн");
if(numbers == 2) 
Console.WriteLine("Вт");
if(numbers == 3) 
Console.WriteLine("Ср");
if(numbers == 4) 
Console.WriteLine("Чт");
if(numbers == 5) 
Console.WriteLine("Пт");
if(numbers == 6) 
Console.WriteLine("Сб");
if(numbers == 7) 
Console.WriteLine("Вс");

else
{
Console.WriteLine("Такого дня нет");
}
// Напишите программу, которая на входд принимает одно число (N),а на выходе показывает все целые числа в промежутке от -N до N
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = -1*number; i <= number; i++)
{
    Console.Write(i.ToString() + " ");
}

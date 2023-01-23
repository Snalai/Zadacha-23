//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0)
{
    Console.Write("Принимаются только числа от 1!");
}
else
{
    for (int i = 1; i <= N; i++)
    {
        int y = i * i * i;
        Console.WriteLine(y);
        y = 0;
    }
}

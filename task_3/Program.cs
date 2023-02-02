// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Число" + "\t" + "В кубе");
int i = 0;

while(i <= num)
    {
    Console.WriteLine(i + "\t" + i * i * i);
    i = i + 1;
    }

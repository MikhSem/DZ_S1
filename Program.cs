// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1>num2)
{
    Console.WriteLine ("Первое число больше, чем второе");
}
else 
{
    Console.WriteLine ("Второе число больше, чем первое");
}
*/
// Проверку на равенство не делал, строго следуя условию задачи. Хотя нужно было бы.

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (max < number2)
{
    max = number2;
}

if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Максимальное число : {max}");
*/

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("Это чётное число");
}
else
{
    Console.WriteLine("Это нечётное число ");
}
*/

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count  = 1;

while (count < number)
{
if (count % 2 == 0)
{
    Console.Write ($" {count}");
}
count ++;
}

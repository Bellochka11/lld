// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine ("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 % 2 == 0)
{
    Console.WriteLine ($"Число {num1} четное ");
}
else
{
    Console.WriteLine ($"Число {num1} не четное ");
}
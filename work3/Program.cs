// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введи цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());
if (number > 7) Console.WriteLine("Нет такого дня недели");
else
{
    if (number == 6)
    {
        Console.WriteLine("Выходной");
    }
    if (number == 7)
    {
        Console.WriteLine("Выходной");
    }
    if (number < 6)
    {
        Console.WriteLine("этот день не выходной");
    }
}
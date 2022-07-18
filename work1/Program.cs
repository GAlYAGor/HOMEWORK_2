// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число");
int chislo = int.Parse(Console.ReadLine());

int chislo2 = ((chislo/10)%10);

Console.Write(chislo2);

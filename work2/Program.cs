// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine());
string number1 = Convert.ToString(number);
if (number1.Length > 2)
{
  Console.WriteLine("третья цифра:" + number1[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}

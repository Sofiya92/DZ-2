// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number<100)
{
    Console.Write("Ошибка, в числе меньше 3 цифр. Введите новое число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

while (number > 999)
{
   number = number / 10;
}
number = number % 10;
Console.WriteLine(number);
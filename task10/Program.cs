// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<100 || number > 1000)
{
    Console.WriteLine("Ошибка, ведите трёхзначное число");
    return;
}

int firstDigit = number % 100;
int secondDigit = firstDigit / 10;
Console.WriteLine(secondDigit);
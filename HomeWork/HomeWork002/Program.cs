﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. (Если решаете математически через рандом, то проверка не нужна на трехзначность. 
// Если через строки, то она обязательна)
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(1000);
string NumStr = num.ToString();
Console.WriteLine($"Вторая цифра числа {num} --> {NumStr[1]}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. (Если решаете математически максимум берем 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int number = new Random().Next(10000);
string NumString = number.ToString();
if (NumString.Length >= 3)
{
    Console.WriteLine($"Третья цифра числа {number} --> {NumString[2]}");
}
else
{
    Console.WriteLine($"Третьей цифры у числа {number} нет");

}
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным. 
// (Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine()!);
if (day < 1 || day > 7){
Console.WriteLine($"Число {day} не лежит в промежутке от 1 до 7");
}
if (day >= 1 && day <= 5){
Console.WriteLine($"Число {day} не выходной");
}
if (day == 6 || day == 7) {
Console.WriteLine($"Число {day} выходной");
}
﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// просим ввести ТРЕХЗНАЧНОЕ число
// разбиваем число на три цифры
// выводим второе число

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int SecondDigit = number / 10 % 10;
Console.WriteLine($"вторая цифра {SecondDigit}: ");

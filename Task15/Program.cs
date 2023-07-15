// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) Console.WriteLine("Сегодня понедельник, будний день");
if (number == 2) Console.WriteLine("Сегодня вторник, будний день");
if (number == 3) Console.WriteLine("Сегодня среда, будний день");
if (number == 4) Console.WriteLine("Сегодня четверг, будний день");
if (number == 5) Console.WriteLine("Сегодня пятница, будний день");
if (number == 6) Console.WriteLine("Сегодня суббота - ВЫХОДНОЙ!!!");
if (number == 7) Console.WriteLine("Сегодня воскресенье - ВЫХОДНОЙ!!!");
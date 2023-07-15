//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()); 

if (number < 100 )
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    int X = number;
    while (X / 1000 >=1)
    {
        X = (X - X % 10) / 10;
    }
    int ThirdDigit = X % 10;
    Console.WriteLine($"Третья цифра числа {number}: {ThirdDigit} ");
}


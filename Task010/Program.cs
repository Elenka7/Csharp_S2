// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");

int threedigit = int.Parse(Console.ReadLine()!);
if (threedigit > 100 && threedigit < 1000)
{
    Console.WriteLine($"Вторая цифра этого числа {threedigit / 10 % 10}");
}
else
{
    Console.WriteLine("Ошибка. Это число не трёхзначное.");
}
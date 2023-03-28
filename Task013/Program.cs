// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 99)
{
    Console.WriteLine("Третьей цифры в этом числе нет.");
}
else
{
    int result = num / 10;
    for (int i = 1; ; i++)
    {
        if (result == 0)
        {
            //result = result * 1000 % 10;
            Console.WriteLine($"Третья цифра числа {result}");
        }
        else
        {
            result = result / 10;
        }
    }
}
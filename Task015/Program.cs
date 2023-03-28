// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
int weekdigit = new Random().Next(1, 7);

Console.WriteLine(weekdigit);

if (weekdigit == 6 && weekdigit == 7)
{
    Console.Write("Ура! Выходной!");
}
else
{
    Console.Write("Делу время, рабочий день.");
}
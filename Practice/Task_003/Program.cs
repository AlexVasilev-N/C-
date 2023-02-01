
/*
Задача №3. Напишите программу, 
которая будет выдавать название дня 
недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/



Console.Write("введите день недели: ");
int input = int.Parse(Console.ReadLine() ?? "");


if (input == 1)
{
Console.WriteLine("Понедельник");
}
else if (input == 2)
{
Console.WriteLine("Вторник");
}
else if (input == 3)
{
Console.WriteLine("Среда");
}
else if (input == 4)
{
Console.WriteLine("Четверг");
}
else if (input == 5)
{
Console.WriteLine("Пятница");
}
else if (input == 6)
{
Console.WriteLine("Суббота");
}
else if (input == 7)
{
Console.WriteLine("Воскресенье");
}
else
Console.WriteLine("Неизвестное число");


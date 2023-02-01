
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number >=100 && number <=999)
{
	number = number % 10;
	Console.WriteLine(number);
}
else
{
	Console.WriteLine("что-то не то");
}

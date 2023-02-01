
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number < 0)
{
	Console.WriteLine("Неверный ввод");
}
else
{
	int count = -number;

	while (count <= number)
    {   
	Console.Write($"{count} "); //(count + " ");
	count++;
    }
}

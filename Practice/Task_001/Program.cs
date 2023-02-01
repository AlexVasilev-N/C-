


Console.Write("введите число: ");
string numberStr = Console.ReadLine() ?? "";

int number = int.Parse(numberStr);

int result = number * number;

Console.WriteLine($" квадрат числа {number} = {result}");


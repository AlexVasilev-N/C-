//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8




Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
if (number <= 0)
{
	Console.WriteLine("Неверный ввод");
}
else if (count / 2 !=1)
{
	while (count <= number)
    {
	    Console.Write($"{count} "); //(count + " ");
	    count++;
    }
}









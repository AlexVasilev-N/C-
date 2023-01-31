//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 //какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


int a = 5;
int b = 7;
int max = a;

if (a > b) max = a;
else max = b;


Console.WriteLine(max);

int a1 = -9;
int b1 = -3;
int max1 = a1;

if (a1 > b1) max1 = a1;
else max1 = b1;


Console.WriteLine(max1);

int a2 = 2;
int b2 = 10;
int max2 = a2;

if (a2 > b2) max2 = a2;
else max2 = b2;


Console.WriteLine(max2);
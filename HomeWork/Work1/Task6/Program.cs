﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
///является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


int a = 4;


if ( a % 2 != 1 ) 
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine ("Не четное число");
}    
    

int EvenNumbers ( int a) 
{
    if ( a % 2 !=0) return a ;
    else return a ;
}


EvenNumbers(4);

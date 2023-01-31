
// Лекция 4. Двумерные массивы и рекурсия. 

Двумерные массивы 

string[,] table = new string [2,5];

table[1,2] = "слово";

for (int rows = 0; rows < 2; rows ++)
{
	for (int columns =0; columns < 5; columns++)
	{

		Console.WriteLine($"{table[rows, columns]}")

	}

}



int[,] matrix = new int [3,4];

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 4; j++)
	{
		Console.WriteLine($" {matrix [i,j]} ");
	}
}


// для методов и функций лучше делать так

int[,] matrix = new int [3,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		Console.WriteLine($" {matrix [i,j]} ");
	}
}

// метод


int[,] matrix = new int [3,4];

void PrintArray(int[,] matr)
{
	int[,] matrix = new int [3,4];

	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			Console.Write($" {matr [i,j]} ");
		}
		Console.WriteLine();
	}
}


void FillArray (int[,] matr)
{
	for ( int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i , j] = new Random().Next(1,10);
		}
	}
}



int[,] matrix = new int [3,4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);



// Закрасть рисуннок.


int [,] pic = new int [,]  // можно заполнять массив самостоятельно
{
	{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


void PrintImage (int[,] image)
{
	for (int i = 0; i < image.GetLength(0); i++)
	{
		for ( int j = 0; j < image.GetLength(1); j++)
		{
			if (image[i,j] == 0) Console.Write($" ");
			else Console.Write($"+");
		}
		Console.WriteLine();
	}
}

void FillImage (int row, int col)
{
	if (pic [row, col] == 0)
	{
		pic [row, col] = 1;
		FillImage(row - 1, col); // рекурсия. Метод вызывающий сам себя.
		FillImage(row, col - 1);
		FillImage(row + 1, col);
		FillImage(row, col + 1);

	}
}


PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);


// Метод Факториала

int Factorial (int n)
{
	if (n == 1) return 1;
	else return n * Factorial(n -1);

}

for (int i = 1; i < 40; i++)
{
	Console.WriteLine ($"{i}! = {Factorial(i)}");
}


// числа Фибоначи

int Fibonacci (int n)
{
	if (n == 1 || n ==2) return 1;
	else return Fibonacci (n - 1 ) + Fibonacci (n - 2);
}

for (int i = 1; i < 10; i++)
{
	Console.WriteLine(Fibonacci(i));
}

int Fibonacci (int n)
{
	if (n == 1 || n ==2) return 1;
	else return Fibonacci (n - 1 ) + Fibonacci (n - 2);
}

for (int i = 1; i < 10; i++)
{
	Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}













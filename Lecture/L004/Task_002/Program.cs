


int[,] matrix = new int [3,4];

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 4; j++)
	{
		Console.Write($" {matrix [i,j]} ");
	}
    Console.WriteLine();
}

Console.WriteLine();

int[,] matrix1 = new int [3,4];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
	for (int j = 0; j < matrix1.GetLength(1); j++)
	{
		Console.Write($" {matrix1[i,j]} ");
	}
    Console.WriteLine();
}
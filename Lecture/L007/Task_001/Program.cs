string NumbersFor (int a, int b)
{
	string result = String.Empty;
	for (int i = a; i <= b; i++)
	{
		result += $"{i} ";
	}
	return result;
}

// Рекурсия 

string NumersRec (int a, int b)
{
	if (a <= b) return $"{a} " + NumersRec(a + 1, b);
	else return String.Empty;
}


Console.WriteLine ( NumbersFor(1,10));
Console.WriteLine ( NumersRec(1,10));


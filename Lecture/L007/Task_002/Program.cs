int SumFor(int a)
{
	int result = 0;
	for (int i = 1; i <= a; i++) result +=i;
	return result;
	
}

// Рекурсия

int SumRec (int n)
{
	if (n == 0) return 0;
	else return n + SumRec (n - 1);
}

Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55

// Лекция 7. Рекурсия продолжение. 


//Рекурсия метод возвращающий сам себя


//ВАЖНО!!!
// Описать условие выхода из рекурсии!!!

// Собрать строку с числами от а до б. a <= b

// Стандартное решение (вевление\циклы)

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


Console.WriteLine ( NumbersFor(1,10)); // 1 2 3 4 5 6 7 8 9 10 
Console.WriteLine ( NumersRec(1,10));  // 1 2 3 4 5 6 7 8 9 10 


// сумма чисел от 1 до n

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




// факториал числа 

int FactorialFor (int n)
{
	int result = 1;
	for ( int i = 1; i <= n; i++) result *= i;
	return result
}

int FactorialRec (int n)
{
	if ( n == 1) return 1;
	else return n * FactorialRec (n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800



// Вычислить а в стемени n 

int PowerFor ( int a, int n)
{
	int result = 1;
	for (int i = 1; i <= n; i++) result *=a;
	return result;

}


int PowerRec ( int a, int n)
{
	return n == 0 ? 1 : PowerRec (a, n -1) * a;
	//if (n == 0) return 1;
	//else return PowerRec (a, n - 1) * a;
}


int PowerRecMath (int a, int n)
{
	if (n ==0) return 1;
	else if ( n % 2 == 0) return PowerRecMath(a * a, n / 2);
	else return PowerRecMath (a, n - 1) * a;
}


Console.WriteLine(PowerFor(2,10));
Console.WriteLine(PowerRec(2,10));
Console.WriteLine(PowerRecMath(2,10));




// перебор слов


char[] s1 = {'a', 'и', 'с', 'в'};

int count1 = s1.Length;

int n1 = 1;

for ( int i = 0; i < count1; i++)
{
	Console.WriteLine( $"{n1++, -5} {s1[i]}");
}

Console.WriteLine();

// перебор слов

char[] s = { 'a', 'и', 'с', 'в'};

int count = s.Length;

int n2 = 1;

for ( int i = 0; i < count; i++)
{
	Console.WriteLine( $"{n2++, -5}{s[i]}");
}
Console.WriteLine();

int n = 1;

void FindWords (string alphabet, char[] word, int length = 0)
{
	if (length == word.Length)
	{
		Console.WriteLine($"{n++} {new String(word)}"); return;
	
	}
	for (int i = 0; i < alphabet.Length; i++)
	{
		word[length] = alphabet[i];
		FindWords(alphabet, word, length + 1);
	}
}

FindWords("аисв", new char [2]);



// обратная сторона рекурсии

Время выполнения задачи.
Не забыть условия выхода!

































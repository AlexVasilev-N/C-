


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

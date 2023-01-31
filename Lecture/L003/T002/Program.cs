string text = " дан текст, который необходимо изменить. Вроде все "
            + "правильно, но что-то не работает. Интересно что?";

string Replace ( string text, char oldValue, char newValue)
{
	string result = String.Empty;

	int length = text.Length;
	for ( int i = 0; i < length; i++)
	{
		if (text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}

string newText = Replace (text, ' ', '!');
Console.WriteLine(newText);

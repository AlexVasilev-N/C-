void Method2 (string msg);
{
	Console.WriteLine (msg);
}

//# Вызов метода

Method2(msg: " Text msg");


// 3 гр что-то возврыщают но 
//ничего не принимают


int Method3()
{
	return DataTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// 4гр что-то принимают,
// Что-то возвращают 

string Method4(int count, string text)
{
	int i = 0;
	string result = "";
	// string result = String.Empty;
	while (i < count)
	{
		result = result + text;
		i++;
	}
	return result;
}

string res = Method4 (10, "asdf");
Console.WriteLine(res);


// цикл for 

for (int i = 0; i<10; i++)
{
	Console.WriteLine(i);
}

// Через цикл for
string Method4(int count, string text)
{
	string result = "";
	// string result = String.Empty;
	for (int i = 0; i < count; i++)
	{
		result = result + text;
	}
	return result;
}

string res = Method4 (10, "asdf");
Console.WriteLine(res);



// цикл в цикле
// вывод таблицы умножения 

for (int i = 2; i <=10: i++)
{
	for (int j = 2; j <= 10; j++)
	{
		Console.WriteLine($"{i} * {j} = {i * j}");
	}
}


// Работа с текстом 

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


// алгоритм выбора 
// Сортировка массива

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Console.WriteLine($"{array[i]}");
	}
	Console.WriteLine();
}

PrintArray(arr);


void SelectionSotr (int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;

		for (int j = i + 1; j < array.Length; j++)
		{
			if(arr[j] < array[minPosition]) minPosition = j;
		}

		int temporary = array[i];
		array[i] = array [minPosition];
		array[minPosition] = temporary;
	}

}

SelectionSotr(arr);
PrintArray (arr);































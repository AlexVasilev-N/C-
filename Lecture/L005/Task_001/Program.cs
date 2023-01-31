
using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
			.Replace ("(", "") // Убирает/ Меняет не нужное из строк
			.Replace (")", "")
			;
Console.WriteLine(text);

var data = text.Split (" ") // Разбивает строку по указанному разделителю.
			.Select(item => item.Split(','))
			.Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // переделывает в числа
			.Where(e => e.x % 2 == 0) // Находит в строке только четные 
			.Select(point => (point.x * 10, point.y)) // увеличивает х на 10, y - не меняется
			.ToArray(); // Превращает в массив

for (int i = 0; i < data.Length; i++)
{
	Console.WriteLine(data[i]);
	
	Console.WriteLine();
}

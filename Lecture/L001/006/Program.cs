

Console.Write("Введите свое имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Маша")
{
    Console.WriteLine ("Ура этоже Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

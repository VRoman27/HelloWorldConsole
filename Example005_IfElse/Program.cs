Console.Write("Введите имя:");
string username = Console.ReadLine();

if(username.ToLower() == "денис")
{
    Console.WriteLine("Денчик ушёл в металл!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

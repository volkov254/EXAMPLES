Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "таня")
{
    Console.WriteLine("Ура, мы так долго тебя ждали");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
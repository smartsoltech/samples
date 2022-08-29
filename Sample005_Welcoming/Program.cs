// new project
Console.WriteLine("Enter your name> ");
string username = Console.ReadLine();
Console.Write("Hello, ");
Console.WriteLine(username);
if (username.ToLower() == "andrey")
{
 Console.WriteLine("Welcome, Master!");
}
else
{
 Console.Write("Hello, ");
 Console.WriteLine(username);
}
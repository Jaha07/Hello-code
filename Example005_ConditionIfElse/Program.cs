Console.WriteLine("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "maria")
{
    Console.WriteLine("Oh, it's Maria!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
Console.Write("Enter the user name ");
string username = Console.ReadLine();

if(username.ToLower() == "masha") // теперь условие не чуствительно к регистру (m M)
{
    Console.WriteLine("Wow, it's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
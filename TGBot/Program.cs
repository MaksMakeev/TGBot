namespace TGBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings!");
            string userName = "Unknown guy";

            while (true)
            {
                Console.WriteLine("You could use these commands:\n/start\n/help\n/info\n/exit");
                if(userName != "Unknown guy")
                {
                    Console.WriteLine("/echo");
                }
                var userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case "/start":
                        Console.WriteLine("Please, insert your name: ");
                        userName = Console.ReadLine();
                        if (userName == "Max")
                        {
                            Console.WriteLine($"Nice to meet you, {userName}!");
                        }
                        else
                        { 
                            Console.WriteLine($"As you wish, {userName}...");
                        }
                        Console.WriteLine("By the way, now you could use /echo command as well!");
                        break;
                    case "/help":
                        Console.WriteLine($"What do you want to know, {userName}?\nDon't tell me!\nYou wonna know what commands you could use. Here you are!");
                        break;
                    case "/info":
                        Console.WriteLine($"That information is supposed to be interesting for you, {userName}.\nThis is the coolest TG bot you've ever used of v1.0, created by Max on 23.06.2024");
                        break;
                    case "/exit":
                        Console.WriteLine($"By, {userName}!");
                        return;
                    default:
                        if (userName != "Unknown guy" && userCommand.Substring(0, 5) == "/echo")
                        {
                            Console.WriteLine(userCommand.Substring(5));
                        } else
                        { 
                            Console.WriteLine("Try something else!"); 
                        }
                        break;
                }
            }
        }
    }
}
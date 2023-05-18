Console.Write("Введите Ваше имя, ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
    {
        Console.WriteLine("Сильно тебя приветствую, Маша");
    }
else
    {
        Console.WriteLine("Мы тебе не рады, " + username);
    }
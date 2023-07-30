namespace MethodsHomeWork;

public static class GreetingClass
{

    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome User!");
    }

    public static string AskUsersName()
    {
        Console.Write("What is your first name : ");
        string output  = Console.ReadLine();
        return output;
    }

    public static void SayHi(string username)
    {
        Console.WriteLine($"Hello {username}");
    }
}

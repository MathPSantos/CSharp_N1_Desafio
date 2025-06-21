namespace CSharp_N1_Desafio;
public class Welcome
{
    public static void Run()
    {
        Console.WriteLine("Qual o seu nome?");
        var userName = Console.ReadLine();
        Console.WriteLine($"Olá, {userName}! Seja muito bem-vindo!");
    }
}

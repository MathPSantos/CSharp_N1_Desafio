namespace CSharp_N1_Desafio;
public class Fullname
{
    public static void Run()
    {
        Console.WriteLine("Qual o seu primeiro nome?");
        var firstName = Console.ReadLine();
        Console.WriteLine("Qual o seu último nome?");
        var lastName = Console.ReadLine();
        Console.WriteLine($"Olá, {firstName} {lastName}!");
    }
}

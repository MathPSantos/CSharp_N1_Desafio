namespace CSharp_N1_Desafio;
public class Mathematic
{
    public static void Run()
    {
        Console.WriteLine("Digite um número:");
        var number1 = Console.ReadLine();
        Console.WriteLine("Digite outro número?");
        var number2 = Console.ReadLine();

        int x = 0;
        int y = 0;

        if (Int32.TryParse(number1, out x) && Int32.TryParse(number2, out y))
        {
            Console.WriteLine($"Soma: {x + y}");
            Console.WriteLine($"Subtração: {x - y}");
            Console.WriteLine($"Multiplicação: {x * y}");

            if (x != 0 && y != 0)
            {
                Console.WriteLine($"Divisão: {x + y}");
            } else
            {
                Console.WriteLine("Não foi possível fazer divisão");
            }
            Console.WriteLine($"Média: {(x + y) / 2}");
            return;
        } else
        {
            Console.WriteLine("Valores inválidos");
        }
    }
}

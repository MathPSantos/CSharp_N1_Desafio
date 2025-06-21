namespace CSharp_N1_Desafio;
public class CountChars
{
    public static void Run()
    {
        Console.WriteLine("Digite palavras separadas por espaço:");
        var input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Input inválido.");
            return;
        }

        var words = input.Split(' ');

        foreach (var word in words)
        {
            var charactersCount = CountCharsFromWord(word);
            Console.WriteLine($"Palavra {word} tem {charactersCount} letras.");
        }
    }

    private static int CountCharsFromWord(string word) {
        return word.Length;
    }
}

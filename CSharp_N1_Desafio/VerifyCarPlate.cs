namespace CSharp_N1_Desafio;
public class VerifyCarPlate
{
    public static void Run()
    {
        Console.WriteLine("Digite placa de carro:");
        var input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Placa inválida");
            return;
        }

        var isValid = VerifyPlate(input);

        if (isValid)
            Console.WriteLine("Verdadeiro");
        else
            Console.WriteLine("Falso");
    }

    private static bool VerifyPlate(string plate)
    {
        if (plate.Length != 7) return false;
        
        for (int i = 0; i < plate.Length; i++)
        {
            char character = plate[i];

            if (i <= 2)
            {
                if (char.IsDigit(character) || !char.IsUpper(character))
                    return false;
            } else
            {
                if (!char.IsDigit(character))
                    return false;
            }
        }
        
        return true;
    }

}

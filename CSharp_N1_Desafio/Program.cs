using CSharp_N1_Desafio;

namespace CsharpN1Desafio;

public class Program {
    static void Main()
    {
        Console.WriteLine("Programas disponíveis: \n" +
            "1. Seja bem-vindo\n" +
            "2. Nome Completo\n" +
            "3. Matemática\n" +
            "4. Contar letras\n" +
            "5. Verificar placa 2018\n" +
            "6. Exibir data atual\n" +
            "\nSelecione uma opção:");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1": 
                Welcome.Run();
                break;
            case "2": 
                Fullname.Run();
                break;
            case "3":
                Mathematic.Run();
                break;
            case "4":
                CountChars.Run();
                break;
            case "5":
                VerifyCarPlate.Run();
                break;
            case "6":
                CurrentDate.Run();
                break;
            default:
                Console.WriteLine("Valor inválido");
                break;
        }
    }
}

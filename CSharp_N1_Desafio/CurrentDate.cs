namespace CSharp_N1_Desafio;
public class CurrentDate
{
    public static void Run()
    {
        var date = DateTime.Now;
        var formats = new List<string>
            { 
                "dddd, dd MMMM yyyy, HH:mm:ss",
                "dd/MM/yyyy",
                "HH:mm",
                "dd MMMM yyyy",
            };

        foreach (var format in formats)
        {
            Console.WriteLine(date.ToString(format));
        }
    }
}

namespace PeopleProject.Functions;

public class Funcoes{
    // só para agilizar meu trabalho
    public static void Clear()
    {
        Console.Clear();
    }

    public static void WriteText(string text){
        Console.Write(text);
    }

    public static void WriteLText(string text){
        Console.WriteLine(text);
    }

    public static string FormatCPF(string cpf)
    {
        return cpf.Substring(0, 3) + "." + 
               cpf.Substring(3, 3) + "." +
               cpf.Substring(6, 3) + "-" +
               cpf.Substring(9, 2);

    }
}
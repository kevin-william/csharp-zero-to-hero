namespace Calculadora_console;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo a nossa primeira calculadora");
        Console.WriteLine("Ela possui apenas a operação básica de soma de dois números inteiro");
        
        Console.WriteLine("Digite o primeiro valor: ");
        var valor1 = Console.ReadLine()??string.Empty;
            Console.WriteLine("Digite o segundo valor: ");
        var valor2 = Console.ReadLine()??string.Empty;
        try
        {
            var resultado = Somar(valor1, valor2);        
            Console.WriteLine($"O resultado da soma de {valor1} mais {valor2} é: {resultado}");
        }
        catch (System.ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    private static void Calculadora(string mode, string valor1, string valor2){
        switch (mode)
        {
            case "s":
            case "S":
                Somar(valor1, valor2);
                break;
            case "M":
            case "m":
                Multiplicar(valor1, valor2);
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
    }


    private static int Somar(string valor1, string valor2){
        
        int valorUm;
        int valorDois;
        var flagValorUm = int.TryParse(valor1, out valorUm);
        var flagValorDois = int.TryParse(valor2, out valorDois);
        
        if(flagValorUm && flagValorDois){
            return Somar(valorUm, valorDois);
        }
        throw new ArgumentException("Os valores informador estão no formato incorreto.");
    }

    private static int Multiplicar(string valor1, string valor2){
        
        int valorUm;
        int valorDois;
        var flagValorUm = int.TryParse(valor1, out valorUm);
        var flagValorDois = int.TryParse(valor2, out valorDois);
        
        if(flagValorUm && flagValorDois){
            return Multiplicar(valorUm, valorDois);
        }
        throw new ArgumentException("Os valores informador estão no formato incorreto.");
    }

    private static int Somar(int valor1, int valor2){
        return valor1 + valor2;
    }

    private static int Multiplicar(int valor1, int valor2){
        return valor1 * valor2;
    }
}

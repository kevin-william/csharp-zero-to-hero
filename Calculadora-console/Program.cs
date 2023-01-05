namespace Calculadora_console;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo a nossa primeira calculadora");
        Console.WriteLine("Ela possui apenas a operação básica de soma de dois números inteiro");
        
        Console.WriteLine("Digite o primeiro valor: ");
        
        try
        {
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = Somar(valor1, valor2);
            
            Console.WriteLine($"O resultado da soma de {valor1} mais {valor2} é: {resultado}");
        }
        catch (System.FormatException)
        {
            Console.WriteLine("O valor digitado não é um número inteiro");            
        }


    }

    private static int Somar(int valor1, int valor2){
        return valor1 + valor2;
    }

}

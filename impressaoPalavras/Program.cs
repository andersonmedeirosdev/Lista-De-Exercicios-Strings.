using System.Xml;

namespace impressaoPalavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "";

            Console.WriteLine("Digite uma frase para manipularmos: ");
            frase = Console.ReadLine();

            Console.WriteLine("Em Maíusculas: " + frase.ToUpper());
            Console.WriteLine();

            Console.WriteLine("Em Mínusculas: " + frase.ToLower());
            Console.WriteLine();

            int qtdPalavras = frase.Split(" ").Count();
            Console.WriteLine("A quantidade de Palavras é: " + qtdPalavras);
            Console.WriteLine();

            Console.WriteLine("A ultima palavra da frase é: " + frase.Split(' ').Last());
        }
    }
}
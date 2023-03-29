namespace contarStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase para contarmos o número de palavras: ");
            string textoRecebido = Console.ReadLine();

            int qtdPalavras = textoRecebido.Split(" ").Count();

            Console.WriteLine("A quantidade de palavras é: " + qtdPalavras);
            Console.ReadLine();
        }
    }
}
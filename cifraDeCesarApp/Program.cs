namespace cifraDeCesarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "";

            Console.WriteLine("Digite o texto para criptografar:");
            texto = Console.ReadLine();

            Console.WriteLine("Digite o número de posições:");
            int posicoes = Convert.ToInt32(Console.ReadLine());

            char[] letras = texto.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                if ((char)letras[i] != (char)32)
                {
                    letras[i] += (char)posicoes;
                }
            }

            Console.Write("Aqui está o resultado da criptografia: ");
            Console.WriteLine(letras);
        }
    }
}
using System.Runtime.CompilerServices;

namespace projetoCidadesApp
{
    internal class Program
    {
        static IEnumerable<string> query = null;
        static void Main(string[] args)
        {
            string[] municipios = File.ReadAllLines("C:\\Users\\55499\\OneDrive\\Documentos\\Exercícios Academia do Programador\\Lista De Exercícios - Strings\\projetoCidadesApp\\Cidades.csv");

            Console.WriteLine("Digite [1] para ver os Municípios.");
            Console.WriteLine("Digite [2] para ver os Municípios e Estados.");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao)
            {
                case 1: GerarMunicipios(municipios); break;
                case 2: GerarEstados(municipios); break;
            }

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void GerarMunicipios(string[] municipios)
        {
            query =
            from municipio in municipios
            let x = municipio.Split(';')
            orderby x[2]
            select x[2];
        }

        private static void GerarEstados(string[] municipios)
        {
            query =
            from municipio in municipios
            let x = municipio.Split(';')
            orderby x[3] , x[2]
            select x[3] + " ; " + x[2];
        }


    }
}
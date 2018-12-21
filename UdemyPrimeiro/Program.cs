using System;

namespace UdemyPrimeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com seu uartos");
            int uartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu preço");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("tudo");
            string[] dados = Console.ReadLine().Split(' ');

            foreach (string dado in dados)
            {
                Console.WriteLine(dado);
                Console.WriteLine(nome);
                Console.WriteLine(uartos);
            }
        }
    }
}

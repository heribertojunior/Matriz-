using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdnome=2;


            Console.WriteLine("Digite quantos nomes quer:");
           qtdnome = Int32.Parse(Console.ReadLine());

            String[,] nome = new string[qtdnome, 2];

            for (int i = 0; i < qtdnome; i++)
            {
                for (int j = 0; j < qtdnome; j++)
                {
                   
                    if (j == 1)
                    {
                        Console.WriteLine("Dgite o sobrenome da " + (i + 1) + " pessoa");
                        nome[i, j] = Console.ReadLine();
                    }else{
                        Console.WriteLine("Dgite o nome da " + (i + 1) + " pessoa");
                        nome[i, j] = Console.ReadLine();
                    }
                }
            }
            for (int i = 0; i < qtdnome; i++)
            {
                for (int j = 0; j < qtdnome; j++)
                {
                    Console.Write(" " + nome[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}

using System;
namespace Teste1
{
    public class Cliente
    {

        public int[] idade = new int[3];
        public string[] nome = new string[3];
        public int[] cod = new int[3];

        public void cad()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                cod[i] = i;
                Console.WriteLine("Digite o nome:");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade:");


                idade[i] = Int32.Parse(Console.ReadLine());
                Console.Clear();
                Console.ReadKey();
            }

        }
        public void listar()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Codigo: " + cod[i]);
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Idade: " + idade[i] + "\n\n");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void editar(int cod)
        {
            Console.Clear();
            Console.WriteLine("Digite :");
            Console.WriteLine("1 :Para editar o Nome");
            Console.WriteLine("2 :Para editar a idade");
            if (Int32.Parse(Console.ReadLine()) == 1)
            {
                Console.Clear();
                Console.WriteLine("Digite o Nome");
                nome[cod] = Console.ReadLine();
            }
            else if (Int32.Parse(Console.ReadLine()) == 2)
            {
                Console.Clear();
                Console.WriteLine("Digite o Nome");
                idade[cod] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("edicao feita com sucesso");
            Console.ReadKey();
            Console.Clear();

        }
        public void pesquisarCod(int cod)
        {
            Console.WriteLine("");
        }
        public Cliente()
        {
        }
    }
}

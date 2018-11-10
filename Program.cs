using System;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Cliente c = new Cliente();
            do
            {
                Console.WriteLine("Digite 1 para Cadastrar");
                Console.WriteLine("Digite 2 para Listar");
                Console.WriteLine("Digite 3 para editar");
                Console.WriteLine("Digite 0 para Sair");
                op = Int32.Parse(Console.ReadLine());
                if (op == 1 || op == 2 || op == 3 || op == 0)
                {
                    switch (op)
                    {
                        case 1:
                            c.cad();
                            break;
                        case 2:
                            c.listar();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Digite o codigo da pessoa que deseja alterar");
                            c.editar(Int32.Parse(Console.ReadLine()));
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Volte sempre");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Opcao invalida");
                    Console.ReadKey();
                }

            } while (op != 0);
        }
    }
}

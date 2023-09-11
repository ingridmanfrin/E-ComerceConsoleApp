using E_Commerce.Controller;
using E_Commerce.Model;
using System;
using System.ComponentModel;

namespace E_Commerce
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = -1, id, tipo, quantidadeLugares, quantidadePortas;
            string nomeLoja = "Conforto Móveis", nome;
            decimal preco;

        MobiliaController mobiliaController = new MobiliaController(); 

            while (opcao != 6)
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine($"                Loja {nomeLoja.ToUpper()}                      ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Cadastrar Mobília                      ");
                Console.WriteLine("            2 - Listar todos as Mobílias               ");
                Console.WriteLine("            3 - Consultar Mobília                     ");
                Console.WriteLine("            4 - Atualizar Mobília                     ");
                Console.WriteLine("            5 - Deletar Mobília                       ");
                Console.WriteLine("            6 - Sair                                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                Console.ResetColor();

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Digite um valor interio entre 1 e 6");
                    opcao = 0;
                    Console.ResetColor();
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Cadastrar Mobília\n\n");
                        Console.ResetColor();

                        do
                        {
                            Console.WriteLine("Digite o Tipo da Mobília: ");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o Nome da Mobília: ");
                        nome = Console.ReadLine();

                        nome ??= string.Empty;

                        Console.WriteLine("Digite o Preço da Mobília: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite a quantidade de Lugares do Sofá: ");
                                quantidadeLugares = Convert.ToInt32(Console.ReadLine());

                                mobiliaController.CriarMobilia(new Sofa(mobiliaController.GerarId(), tipo, nome, preco, quantidadeLugares));
                                break;
                            case 2:
                                Console.WriteLine("Digite a quantidade de Portas do Armário: ");
                                quantidadePortas = Convert.ToInt32(Console.ReadLine());

                                mobiliaController.CriarMobilia(new Armario(mobiliaController.GerarId(), tipo, nome, preco, quantidadePortas));

                                break;
                        }

                        KeyPress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Listar Mobília\n\n");
                        Console.ResetColor();

                        mobiliaController.ListarMobilias();

                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Consultar Mobília - por Id\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id da Mobília: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        mobiliaController.ConsultarMobiliaPorId(id);

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Atualizar Mobília\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id da Mobília: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var mobilia = mobiliaController.BuscarNaCollection(id);

                        if (mobilia != null)
                        {
                            Console.WriteLine("Digite o Nome do Produto: ");
                            nome = Console.ReadLine();

                            nome ??= string.Empty;

                            Console.WriteLine("Digite o Preço do Produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            tipo = mobilia.GetTipo();

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite a quantidade de Lugares do Sofá: ");
                                    quantidadeLugares = Convert.ToInt32(Console.ReadLine());

                                    mobiliaController.AtualizarMobilia(new Sofa(id, tipo, nome, preco, quantidadeLugares));
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o Nome Genérico do Produto: ");
                                    quantidadePortas = Convert.ToInt32(Console.ReadLine());

                                    mobiliaController.AtualizarMobilia(new Armario(id, tipo, nome, preco, quantidadePortas));
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"A Mobília de Id {id} não foi encontrada!");
                            Console.ResetColor();
                        }

                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Deletar Mobília\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Id da Mobília: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        mobiliaController.DeletarMobilia(id);

                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"\nConforto Móveis - Móveis feitos para você!");
                        Sobre();
                        Console.ResetColor();
                        KeyPress();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }
            }
        }

        static void Sobre()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: ");
            Console.WriteLine("Ingrid Manfrin - ingridevelyn.manfrin@gmail.com");
            Console.WriteLine("github.com/ingridmanfrin/E-CommerceConsoleApp");
            Console.WriteLine("*********************************************************");

        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
    }
}

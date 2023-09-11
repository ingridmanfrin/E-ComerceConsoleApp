using System;

namespace E_Commerce
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = -1, id;
            string nomeLoja = "Sofás Conforto";

            while (opcao != 6)
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine($"                Loja {nomeLoja.ToUpper()}                      ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Cadastrar Produto                      ");
                Console.WriteLine("            2 - Listar todos os Produtos               ");
                Console.WriteLine("            3 - Consultar Produto                     ");
                Console.WriteLine("            4 - Atualizar Produto                     ");
                Console.WriteLine("            5 - Deletar Produto                       ");
                Console.WriteLine("            6 - Sair                                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Criar Produto\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Listar Produtos\n\n");
                        Console.ResetColor();


                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Consultar Produto - por Id\n\n");
                        Console.ResetColor();


                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Atualizar Produto\n\n");
                        Console.ResetColor();


                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Apagar o Produto\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"\nSofás Conforto - Aconchegue-se!");
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

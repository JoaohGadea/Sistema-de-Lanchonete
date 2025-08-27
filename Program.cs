using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop1 = true;
            bool loop2 = true;
            bool loop3 = true;

            char resposta1;
            char resposta2;
            char resposta3;

            while (loop1)
            {
                ListarGeral();
                resposta1 = Convert.ToChar(Console.ReadLine());

                switch (resposta1)
                {
                    case '1':
                        while (loop2)
                        {
                            ListarComandosUsuario();
                            resposta2 = Convert.ToChar(Console.ReadLine());
                            switch (resposta2)
                            {
                                case '1':
                                    Console.WriteLine("Cadastrou um usuário\nAinda no futuro");
                                    break;
                                case '2':
                                    Console.WriteLine("Editou um usuário\nAinda no futuro");
                                    break;
                                case '3':
                                    Console.WriteLine("Excluiu o usuário\nAinda no futuro");
                                    break;
                                case '4':
                                    Console.WriteLine("Listou os usuários\nAinda no futuro");
                                    break;
                                case '5':
                                    Console.WriteLine("Saindo da sessão usuário...");
                                    loop2= false;  
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        }
                        Console.ReadKey();
                        break;

                    case '2':
                        float total = 0;
                        while (loop3)
                        {
                            ListarLanchonete();
                            resposta3 = Convert.ToChar(Console.ReadLine());
                            switch (resposta3)
                            {
                                case '1':
                                    Console.WriteLine("Coca-Cola adicionada ao pedido...");
                                    total += 5;
                                    Console.WriteLine($"Total: {total}");
                                    break;
                                case '2':
                                    Console.WriteLine("Suco de laranja adicionada ao pedido...");
                                    total += 6;
                                    Console.WriteLine($"Total: {total}");
                                    break;
                                case '3':
                                    Console.WriteLine("Água adicionada ao pedido...");
                                    total += 3;
                                    Console.WriteLine($"Total: {total}");
                                    break;
                                case '4':
                                    Console.WriteLine("Café foi adicionado ao pedido...");
                                    total += 4;
                                    Console.WriteLine($"Total: {total}");
                                    break;
                                case '5':
                                    Console.WriteLine("Finalizando o pedido...");
                                    Console.WriteLine($"O total do pedido foi:R${total:f2}");
                                    loop3 = false;
                                    break;
                                default:
                                    Console.WriteLine("Opção Inválida");
                                    break;
                            }
                        }
                        Console.ReadKey();
                        break;

                    case '3':
                        loop1 = false;
                        Console.WriteLine("Saindo do programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            }

        }
        static void ListarGeral()
        {
            Console.WriteLine("Sistema da Lanchonete \nO que deseja?");
            Console.WriteLine("1 - Acessar o sistema de usuários:");
            Console.WriteLine("2 - Comprar na lanchonete:");
            Console.WriteLine("3 - Sair");
        }
        static void ListarComandosUsuario(){
            Console.WriteLine("Bem vindo ao switch case dos crias!");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Editar usuário");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Listar usuário");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Escolha uma opção de 1 a 5");
        }
        static void ListarLanchonete()
        {
            Console.WriteLine("Lanchonete dos crias");
            Console.WriteLine("1 - Coca-Cola (R$ 5,00)");
            Console.WriteLine("2 - Suco de Laranja (R$ 6,00)");
            Console.WriteLine("3 - Água (R$ 3,00)");
            Console.WriteLine("4 - Café (R$4,00");
            Console.WriteLine("5 - Finalizar o pedido:");
            Console.WriteLine("Escolha uma opção de 1 a 5");
        }
    }
}

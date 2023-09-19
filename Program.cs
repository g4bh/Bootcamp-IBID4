﻿namespace ProductManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("--- BEM VINDO(A) AO SISTEMA DE ESTOQUE! ---");

            do
            {
                Console.WriteLine("\n=== MENU DE OPÇÕES ====\n\nO que deseja fazer?\n  \n1 - Adicionar produtos \n2 - Excluir produto \n3 - Atualizar produtos \n4 - Listar produtos \n5 - Sair");
                Console.Write("Selecione uma opção numérica: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        RemoverId();
                        break;
                    case 3:
                        AtualizarProduto();
                        break;
                    case 4:
                        ListarProdutos();
                        break;
                    case 5:
                        Console.WriteLine("\nO programa foi encerrado!");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida! Por favor, digitar novamente.\n");
                        break;
                }
            } while (opcao != 5);
        }
    }
}
﻿using ProductManager.Controller;
using System.Drawing;

namespace ProductManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoController controller = new ProdutoController();
            string opcao;

            Console.WriteLine("===== BEM VINDO(A) AO SISTEMA DE ESTOQUE! =====");

            do
            {
                Console.WriteLine("\n=== MENU DE OPÇÕES ====\n\nO que deseja fazer?\n  \n1 - Adicionar produtos \n2 - Excluir produto \n3 - Atualizar produtos \n4 - Listar produtos \n5 - Sair");

                Console.Write("Selecione uma opção numérica: ");
                opcao = Console.ReadLine();


                if (!int.TryParse(opcao, out int valor))
                {
                    Console.WriteLine("\nAVISO: Entrada inválida. Por favor, insira um número inteiro válido!");
                    continue; 
                }

                switch (opcao)
                { 
                    case "1":
                        controller.CadastrarProduto();
                        break;
                    case "2":
                        controller.RemoverId();
                        break;
                    case "3":
                        controller.AtualizarProduto();
                        break;
                    case "4":
                        controller.ListarProdutos();
                        break;
                    case "5":
                        Console.WriteLine("\nO programa foi encerrado!");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida! Por favor, digitar novamente.\n");
                        break;
                    }
            } while (opcao != "5");
        }
    }
}

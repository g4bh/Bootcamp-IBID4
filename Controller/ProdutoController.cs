using ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Controller
{
    internal class ProdutoController
    {
        private List<Produto> listaProdutos = new List<Produto>();
        int id = 1000;
        public void CadastrarProduto()
        {
            Console.Write("\nInforme o NOME do produto: ");
            string nomeP = Console.ReadLine();

            Console.Write("\nInforme o PREÇO do produto: ");
            float precoP = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            id++; //Criando um novo ID a cada produto inserido 

            Produto novoP = new Produto(id, nomeP, precoP);

            listaProdutos.Add(novoP);

            Console.Write("\nSUCESSO: Produto inserido com sucesso!\n");
        }

        public void RemoverId()
        {

            Console.Write("Informe o ID do produto que deseja excluir: ");
            int Id = int.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 0; i < listaProdutos.Count; i++)
            {
                Produto produto = listaProdutos[i];
                if (produto.GetId() != Id)
                {
                    continue;
                }
                listaProdutos.Remove(produto);
                Console.WriteLine("\nSUCESSO: produto foi excluído com sucesso!\n");
                contador++;
            }

            if (contador == 0)
            {
                Console.WriteLine("AVISO: Não há produtos com esse ID ou não há produtos cadastrados!\n Tente novamente!\n");
            }
        }

        public void AtualizarProduto()
        {

            Console.Write("\nInforme o ID do produto que queira atualizar:");
            int Id = int.Parse(Console.ReadLine());

            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("\nAVISO: Não há produtos para atualizar!");
            }
            else
            {
                foreach (Produto produto in listaProdutos)
                {
                    if (produto.GetId() == Id)
                    {

                        Console.Write("\nInforme o novo nome do produto: ");
                        string novoNome = Console.ReadLine();

                        produto.SetNome(novoNome);

                        Console.Write("\nSUCESSO: Produto atualizado com sucesso!");
                    }

                }
            }

        }

        public void ListarProdutos()
        {
            Console.WriteLine("\n------------------------------\n");
            Console.WriteLine("==== LISTA DE PRODUTOS ===\n");
            
            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("AVISO: Não há nenhum produto inserido!\n");
            }
            else
            {
                foreach (Produto produto in listaProdutos)
                {
                    Console.WriteLine(produto.ToString());
                }
            }

            Console.WriteLine("\n------------------------------\n");
        }
    }
}

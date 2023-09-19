using ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Controller
{
    internal class ProdutoController
    {
        private List<Produto> listaProdutos = new List<Produto>();

        public void CadastrarProduto()
        {
            Console.Write("\nInforme o ID do produto: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do produto: ");
            string nomeP = Console.ReadLine();

            Console.Write("Informe o preço do produto: ");
            float precoP = float.Parse(Console.ReadLine());

            Produto novoP = new Produto(id, nomeP, precoP);

            listaProdutos.Add(novoP);

            Console.Write("\nProduto inserido com sucesso!\n");
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
                Console.WriteLine("\nAVISO: roduto foi excluído com sucesso!\n");
                contador++;
            }

            if (contador == 0)
            {
                Console.WriteLine("AVISO: Não há produtos com esse ID ou não há produtos cadastrados! Tente novamente!");
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

                        Console.Write("\nProduto atualizado com sucesso!");
                    }

                }
            }

        }

        public void ListarProdutos()
        {
            Console.WriteLine("\n--- Lista de produtos ---");
            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("Não há nenhum produto inserido!\n");
            }
            else
            {
                foreach (Produto produto in listaProdutos)
                {
                    Console.WriteLine(produto.ToString());
                }
            }

        }
    }
}

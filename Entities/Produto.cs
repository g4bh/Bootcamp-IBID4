using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Entities
{
    internal class Produto
    {
        private int Id { get; set; }
        private string NomeProduto { get; set; }
        private float PrecoProduto { get; set; }

        public Produto() { }

        public Produto(int id, string nomeP, float precoP)
        {
            Id = id;
            NomeProduto = nomeP;
            PrecoProduto = precoP;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetNome(string novoNome)
        {
            NomeProduto = novoNome;
        }


        public override string ToString()
        {
            return $"\n{Id} - {NomeProduto} | Preço: R${PrecoProduto}";
        }
    }
}

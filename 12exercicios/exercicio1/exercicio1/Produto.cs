using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Produto
    {
        // Atributos da classe
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        // Construtor para inicializar os atributos
        public Produto(string nome, decimal preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        // Método para adicionar itens ao estoque
        public void AdicionarEstoque(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }

        // Método para remover itens do estoque
        public void RemoverEstoque(int quantidade)
        {
            QuantidadeEmEstoque -= quantidade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    public class Produto
    {
        // Atributos da classe
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        // Construtor para inicializar os atributos
        public Produto(int codigo, string nome, decimal preco, int quantidadeEmEstoque)
        {
            Codigo = codigo;
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

    public class Loja
    {
        private List<Produto> produtos;

        public Loja()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void ExibirProdutos()
        {
            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco}, Quantidade em Estoque: {produto.QuantidadeEmEstoque}");
            }
        }

        public Produto ConsultarProduto(int codigo)
        {
            return produtos.Find(p => p.Codigo == codigo);
        }
    }
}

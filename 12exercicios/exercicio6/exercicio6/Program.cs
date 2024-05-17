namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da Loja
            Loja loja = new Loja();

            // Adicionando produtos à loja
            loja.AdicionarProduto(new Produto(1, "Caneta", 1.50m, 100));
            loja.AdicionarProduto(new Produto(2, "Caderno", 5.00m, 50));
            loja.AdicionarProduto(new Produto(3, "Borracha", 0.50m, 200));

            // Exibindo todos os produtos na loja
            loja.ExibirProdutos();

            // Consultando um produto pelo código
            int codigoConsultado = 2;
            Produto produtoConsultado = loja.ConsultarProduto(codigoConsultado);
            if (produtoConsultado != null)
            {
                Console.WriteLine($"Produto encontrado - Código: {produtoConsultado.Codigo}, Nome: {produtoConsultado.Nome}, Preço: {produtoConsultado.Preco}, Quantidade em Estoque: {produtoConsultado.QuantidadeEmEstoque}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}

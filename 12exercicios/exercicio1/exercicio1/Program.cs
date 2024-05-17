namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Produto
            Produto produto = new Produto("Caneta", 1.50m, 100);

            // Exibindo informações iniciais do produto
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");
            Console.WriteLine($"Quantidade em Estoque: {produto.QuantidadeEmEstoque}");

            // Adicionando 20 itens ao estoque
            produto.AdicionarEstoque(20);
            Console.WriteLine($"Quantidade em Estoque após adição: {produto.QuantidadeEmEstoque}");

            // Removendo 10 itens do estoque
            produto.RemoverEstoque(10);
            Console.WriteLine($"Quantidade em Estoque após remoção: {produto.QuantidadeEmEstoque}");
        }
    }
}

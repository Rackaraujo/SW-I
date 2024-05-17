namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de RegistroDeCompras
            RegistroDeCompras registro = new RegistroDeCompras();

            // Adicionando compras ao registro
            registro.AdicionarCompra(DateTime.Now, "Caneta", 1.50m);
            registro.AdicionarCompra(DateTime.Now.AddDays(-1), "Caderno", 5.00m);

            // Listando todas as compras registradas
            Console.WriteLine("Lista de Compras:");
            registro.ListarCompras();
        }
    }
}

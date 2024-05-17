namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Livro livro1 = new Livro("1984", "George Orwell");
                Console.WriteLine($"Livro: {livro1.Titulo}, Autor: {livro1.Autor}");

                Livro livro2 = new Livro("", "Autor Desconhecido"); // Isso irá lançar uma exceção
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            try
            {
                Livro livro3 = new Livro("Livro Sem Autor", ""); // Isso também irá lançar uma exceção
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

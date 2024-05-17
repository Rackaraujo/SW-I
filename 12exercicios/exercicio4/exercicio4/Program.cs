namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da AgendaTelefonica
            AgendaTelefonica agenda = new AgendaTelefonica();

            // Adicionando alguns contatos
            agenda.AdicionarContato("João", "123456789", "joao@example.com");
            agenda.AdicionarContato("Maria", "987654321", "maria@example.com");

            // Buscando e exibindo um contato
            Contato contatoMaria = agenda.BuscarContato("Maria");
            if (contatoMaria != null)
            {
                Console.WriteLine($"Contato encontrado: {contatoMaria.Nome}, {contatoMaria.Telefone}, {contatoMaria.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            // Removendo um contato
            agenda.RemoverContato("João");

            // Tentando buscar o contato removido
            Contato contatoJoao = agenda.BuscarContato("João");
            if (contatoJoao != null)
            {
                Console.WriteLine($"Contato encontrado: {contatoJoao.Nome}, {contatoJoao.Telefone}, {contatoJoao.Email}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }
}

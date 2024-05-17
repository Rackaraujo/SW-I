using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    public class AgendaTelefonica
    {
        // Lista para armazenar os contatos
        private List<Contato> contatos;

        // Construtor da classe AgendaTelefonica
        public AgendaTelefonica()
        {
            contatos = new List<Contato>(); // Inicializa a lista de contatos
        }

        // Método para adicionar um contato à lista
        public void AdicionarContato(string nome, string telefone, string email)
        {
            Contato novoContato = new Contato(nome, telefone, email); // Cria um novo objeto Contato
            contatos.Add(novoContato); // Adiciona o novo contato à lista
        }

        // Método para remover um contato da lista
        public void RemoverContato(string nome)
        {
            // Procura o contato na lista pelo nome e remove se encontrado
            contatos.RemoveAll(contato => contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        // Método para buscar um contato na lista pelo nome
        public Contato BuscarContato(string nome)
        {
            // Procura o contato na lista pelo nome e retorna se encontrado
            return contatos.Find(contato => contato.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
    }

    // Classe para representar um contato
    public class Contato
    {
        // Atributos do contato
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        // Construtor da classe Contato
        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

    }

}

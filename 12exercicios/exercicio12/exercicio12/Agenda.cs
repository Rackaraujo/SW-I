using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    public class Agenda
    {
        private List<Pessoa> pessoas;

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            pessoas.Add(new Pessoa(nome, idade, altura));
            Console.WriteLine("Pessoa armazenada com sucesso.");
        }

        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = pessoas.Find(p => p.Nome == nome);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                Console.WriteLine("Pessoa removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome == nome);
        }

        public void ImprimeAgenda()
        {
            if (pessoas.Count == 0)
            {
                Console.WriteLine("Agenda vazia.");
            }
            else
            {
                foreach (Pessoa pessoa in pessoas)
                {
                    Console.WriteLine(pessoa);
                }
            }
        }
    }
}

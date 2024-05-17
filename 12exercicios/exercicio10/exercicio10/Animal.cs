using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
        }

        public void EmitirSom()
        {
            Console.WriteLine($"{Nome}, que é um(a) {Especie}, está emitindo um som.");
        }
    }
}

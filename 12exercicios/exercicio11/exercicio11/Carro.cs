using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Velocidade { get; private set; }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
            Velocidade = 0; // Inicialmente, a velocidade é 0
        }

        public void Acelerar()
        {
            Velocidade += 10;
            Console.WriteLine($"O carro {Modelo} acelerou. Velocidade atual: {Velocidade} km/h");
        }

        public void Frear()
        {
            if (Velocidade >= 10)
            {
                Velocidade -= 10;
            }
            else
            {
                Velocidade = 0;
            }
            Console.WriteLine($"O carro {Modelo} freou. Velocidade atual: {Velocidade} km/h");
        }
    }
}

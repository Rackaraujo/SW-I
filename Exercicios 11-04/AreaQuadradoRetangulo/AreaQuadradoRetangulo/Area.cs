using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double AreaTotal { get; set; }

        public string Calcular()
        {
            Console.WriteLine("Digite a base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            AreaTotal = Base * Altura;
            string tipo = "";

            if(Base == Altura)
            {
                tipo = "quadrado";
            }
            else
            {
                tipo = "retângulo";
            }

            string resultado = "A área é " + AreaTotal;
            resultado += "\nIsso é um " + tipo;

            return resultado; 
        }

        public string Dados()
        {
            string informacoes = "O valor da base é " + Base;
            informacoes += "\nO valor da altura é " + Altura;

            return informacoes;
        }
    }
}

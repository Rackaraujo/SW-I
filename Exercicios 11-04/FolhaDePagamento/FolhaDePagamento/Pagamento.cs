using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento
{
    public class Pagamento
    {
        public string Nome { get; set; }
        public float Sal { get; set; }
        public float HED { get; set; }
        public float HEN { get; set; }
        public int ND { get; set; }
        public float Fal { get; set; }
        public float DE { get; set; }
        public float REF { get; set; }
        public float Val { get; set; }

        public string FolhaDePagamento()
        {
            double HoraExtra = HED * Sal / 160 + HEN * 1.2 * Sal / 160;
            double SalF = ND * 0.05;
            double INAMPS = 0.08 * Sal;
            double faltas = Fal * Sal / 160;
            double SalB = Sal + HoraExtra + SalF;
            double imposto_de_renda = 0.08 * Sal;

            string informacoes = $"Nome: {Nome} \nSalário: {Sal}\nHoras Extras: {HoraExtra}\nSalário Família: {SalF}" +
            $"\nSalário Mínimo: {SalB}\nINAMPS: {INAMPS}\nFaltas: {faltas}\nRefeições: {REF}\nVales: {Val}" +
            $"\nDescontos Eventuais: {DE}\nImposto de renda: {imposto_de_renda}" +
            $"\nSalário Líquido: {SalB - INAMPS - faltas - REF - Val - DE - imposto_de_renda}";

            return informacoes;
        }
    }
}

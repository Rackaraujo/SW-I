using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    public class Conta
    {
        public string? num_conta { get; set; }
        private float saldo { get; set; }
        private float limite { get; set; }

        public void consulta_saldo()
        {
            Console.WriteLine("Seu saldo é R$" + saldo);
        }

        public void deposito(float dep)
        {
            saldo += dep;
            Console.WriteLine("Seu depósito foi R$" + saldo);
            Console.WriteLine("Você pode sacar até R$" + (saldo + limite));
        }

        public void sacar(float saque)
        {
            if(saque <= saldo + limite)
            {
                saldo -= saque;
                Console.WriteLine("Seu saldo após o saque é R$" + saldo);
            }
            else if(saldo > saque)
            {
                Console.WriteLine("O seu saque não pode ser concluído, o valor excedeu o limite da conta");
            }
        }
        public void ajusta_limite(float lim)
        {
            limite = lim;
            Console.WriteLine($"Seu limite agora é R${limite},00");
        }
    }
}

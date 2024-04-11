namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.ajusta_limite(700);
            conta.deposito(500);

            conta.consulta_saldo();

            conta.sacar(200);

            conta.consulta_saldo();
        }
    }
}
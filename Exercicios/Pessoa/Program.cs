namespace Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Raquel";
            p.DataNasc = new DateTime(2007, 7, 7);
            p.Altura = 1.72f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}
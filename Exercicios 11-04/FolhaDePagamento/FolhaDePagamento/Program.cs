namespace FolhaDePagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pagamento p = new Pagamento();
            p.Nome = "Dave Mustaine";
            p.Sal = 10000;
            p.HED = 0;
            p.HEN = 15;
            p.ND = 0;
            p.Fal = 13;
            p.DE = 5;
            p.REF = 5;
            p.Val = 1;
            Console.WriteLine(p.FolhaDePagamento());
        }
    }
}
namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Armazenar pessoa");
                Console.WriteLine("2. Remover pessoa");
                Console.WriteLine("3. Buscar pessoa");
                Console.WriteLine("4. Imprimir agenda");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Digite a altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;
                    case 2:
                        Console.Write("Digite o nome da pessoa a remover: ");
                        nome = Console.ReadLine();
                        agenda.RemovePessoa(nome);
                        break;
                    case 3:
                        Console.Write("Digite o nome da pessoa a buscar: ");
                        nome = Console.ReadLine();
                        Pessoa pessoa = agenda.BuscaPessoa(nome);
                        if (pessoa != null)
                        {
                            Console.WriteLine(pessoa);
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada.");
                        }
                        break;
                    case 4:
                        agenda.ImprimeAgenda();
                        break;
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}

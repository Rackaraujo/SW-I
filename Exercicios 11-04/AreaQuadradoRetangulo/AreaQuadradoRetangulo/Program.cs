namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula Área Quadrado/Retângulo");

            Area  xyz = new Area();

            Console.WriteLine(xyz.Calcular());

            Console.WriteLine(xyz.Dados());
        }
    }
}
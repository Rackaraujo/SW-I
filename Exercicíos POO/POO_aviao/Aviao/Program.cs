namespace Aviao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao aviao = new Aviao();

            aviao.Marca = "BAe";
            aviao.Modelo = "146";

            aviao.Acelerar(10);
            aviao.Subir(220);

            Console.WriteLine($"A altura do avião é: {aviao.Altitude}m");
            Console.WriteLine($"A velocidade é: {aviao.Velocidade}km/h");
            Console.WriteLine($"A marca é: {aviao.Marca}");
            Console.WriteLine($"modelo é: {aviao.Modelo}");
        }
    }
}
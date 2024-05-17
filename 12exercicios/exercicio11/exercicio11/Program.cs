namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Fusca", 1980);

            carro1.Acelerar();  // Output: O carro Fusca acelerou. Velocidade atual: 10 km/h
            carro1.Acelerar();  // Output: O carro Fusca acelerou. Velocidade atual: 20 km/h
            carro1.Frear();     // Output: O carro Fusca freou. Velocidade atual: 10 km/h
            carro1.Frear();     // Output: O carro Fusca freou. Velocidade atual: 0 km/h
            carro1.Frear();     // Output: O carro Fusca freou. Velocidade atual: 0 km/h (não permite velocidade negativa)
        }
    }
}

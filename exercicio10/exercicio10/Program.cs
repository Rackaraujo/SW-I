namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cachorro = new Animal("Rex", "Cachorro", 5);
            cachorro.EmitirSom();  // Output: Rex, que é um(a) Cachorro, está emitindo um som.

            Animal gato = new Animal("Mimi", "Gato", 3);
            gato.EmitirSom();  // Output: Mimi, que é um(a) Gato, está emitindo um som.

            Animal vaca = new Animal("Mimosa", "Vaca", 7);
            vaca.EmitirSom();  // Output: Mimosa, que é um(a) Vaca, está emitindo um som.
        }
    }
}

namespace AlbumDeFotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número total de páginas do álbum:");
            int numeroTotalDePaginas = Convert.ToInt32(Console.ReadLine());

            Album album = new Album(numeroTotalDePaginas);

            Console.WriteLine("Digite o número de fotos a serem adicionadas:");
            int numeroDeFotos = Convert.ToInt32(Console.ReadLine());

            album.NumeroDeFotos = numeroDeFotos;
        }
    }
}
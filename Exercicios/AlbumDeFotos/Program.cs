namespace AlbumDeFotos
{
    public class Program
    {
        static void Main()
        {
            AlbumDeFotos album = new AlbumDeFotos(10);
            
            Console.WriteLine($"Número total de fotos permitido: {album.NumeroTotalDeFotos}");

            album.NumeroDeFotos = 15;
            Console.WriteLine($"Número de fotos no álbum: {album.NumeroDeFotos}");

            album.NumeroDeFotos = 25;
            Console.WriteLine($"Número de fotos no álbum: {album.NumeroDeFotos}");
        }
    }
}
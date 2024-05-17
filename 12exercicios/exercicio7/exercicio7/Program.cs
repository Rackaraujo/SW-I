namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso
            Playlist minhaPlaylist = new Playlist("Eu");

            minhaPlaylist.AdicionarMusica(new Musica("Thoughtless", "Korn", "Gravadora 1"));
            minhaPlaylist.AdicionarMusica(new Musica("Dystopia", "Megadeth", "Gravadora 2"));
            minhaPlaylist.AdicionarMusica(new Musica("I walk", "Yun Li", "Gravadora 3"));

            // Toca uma música aleatória da playlist
            minhaPlaylist.TocarMusicaAleatoria();
        }
    }
}

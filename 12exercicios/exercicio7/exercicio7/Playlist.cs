using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    public class Playlist
    {
        private List<Musica> listaDeMusicas;
        private string donoDaPlaylist;

        public Playlist(string dono)
        {
            listaDeMusicas = new List<Musica>();
            donoDaPlaylist = dono;
        }

        public void AdicionarMusica(Musica musica)
        {
            listaDeMusicas.Add(musica);
        }

        public void TocarMusicaAleatoria()
        {
            if (listaDeMusicas.Count == 0)
            {
                Console.WriteLine("Playlist vazia. Adicione músicas para tocar.");
                return;
            }

            Random random = new Random();
            int indiceAleatorio = random.Next(0, listaDeMusicas.Count);
            Musica musicaAleatoria = listaDeMusicas[indiceAleatorio];
            Console.WriteLine($"Tocando música: {musicaAleatoria.Nome}");
        }
    }
}

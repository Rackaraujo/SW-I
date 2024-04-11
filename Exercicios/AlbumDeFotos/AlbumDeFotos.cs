using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumDeFotos
{
    public class AlbumDeFotos
    {
        public int NumeroTotalDePaginas { get; set; }
        public int NumeroTotalDeFotos 
        {
            get
            {
                return NumeroTotalDePaginas * 2;
            }
        }

        private int numeroDeFotos;
        public int NumeroDeFotos
        {
            get
            {
                return numeroDeFotos;
            }
            set
            {
                if (value > NumeroTotalDeFotos)
                {
                    Console.WriteLine($"Erro: O álbum ultrapassou o limite de fotos!");
                }
                else
                {
                    numeroDeFotos = value;
                }
            }
        }

        public AlbumDeFotos(int numeroTotalDePaginas) 
        {
            NumeroTotalDePaginas = numeroTotalDePaginas;
            numeroDeFotos = 0;
        }
    }
}

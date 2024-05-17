using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    public class RegistroDeCompras
    {
        // Classe interna para representar uma compra
        public class Compra
        {
            public DateTime Data { get; private set; }
            public string NomeProduto { get; private set; }
            public decimal Valor { get; private set; }

            // Construtor para inicializar os atributos da compra
            public Compra(DateTime data, string nomeProduto, decimal valor)
            {
                Data = data;
                NomeProduto = nomeProduto;
                Valor = valor;
            }
        }

        // Lista para armazenar as compras
        private List<Compra> compras;

        // Construtor para inicializar a lista de compras
        public RegistroDeCompras()
        {
            compras = new List<Compra>();
        }

        // Método para adicionar uma compra ao registro
        public void AdicionarCompra(DateTime data, string nomeProduto, decimal valor)
        {
            Compra novaCompra = new Compra(data, nomeProduto, valor);
            compras.Add(novaCompra);
        }

        // Método para listar todas as compras
        public void ListarCompras()
        {
            foreach (Compra compra in compras)
            {
                Console.WriteLine($"Data: {compra.Data}, Produto: {compra.NomeProduto}, Valor: {compra.Valor}");
            }
        }
    }
}

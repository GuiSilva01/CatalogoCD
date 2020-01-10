using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Models
{
    public class FaixadePreco
    {
        public int Id { get; set; }


        public string NomeFaixa { get; set; }


        public double PrecoInicial { get; set; }


        public double PrecoFinal { get; set; }

        public ICollection<CD> CDs { get; set; } = new List<CD>();

        public FaixadePreco()
        {

        }

        public FaixadePreco(int id, string nomeFaixa, double precoInicial, double precoFinal)
        {
            Id = id;
            NomeFaixa = nomeFaixa;
            PrecoInicial = precoInicial;
            PrecoFinal = precoFinal;        
        }

        public void AddCD(CD cd)
        {
            CDs.Add(cd);
        }
    }
}

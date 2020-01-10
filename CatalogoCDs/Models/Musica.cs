using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Models
{
    public class Musica
    {
        public int Id { get; set; }


        public string Faixa { get; set; }


        public string Artista { get; set; }

        public ICollection<CD> CDs { get; set; } = new List<CD>();

        public Musica()
        {

        }

        public Musica(int id, string faixa, string artista)
        {
            Id = id;
            Faixa = faixa;
            Artista = artista;
            
        }

        public void AddCD(CD cd)
        {
            CDs.Add(cd);
        }
    }
}

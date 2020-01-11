using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Models
{
    public class CD
    {
        public int Id { get; set; }


        public string NomeCD { get; set; }


        public DateTime DtLancamento { get; set; }

        public Gravadora Gravadora { get; set; }

        public int GravadoraId { get; set; }

        public FaixadePreco FaixadePreco { get; set; }

        public int FaixadePrecoId { get; set; }

        public Musica Musica { get; set; }

        public int MusicaId { get; set; }

        public CD()
        {

        }

        public CD(int id, string nomeCD, DateTime dtLancamento, Gravadora gravadora, FaixadePreco faixadePreco, Musica musica)
        {
            Id = id;
            NomeCD = nomeCD;
            DtLancamento = dtLancamento;
            Gravadora = gravadora;
            FaixadePreco = faixadePreco;
            Musica = musica;
        }

    }
}
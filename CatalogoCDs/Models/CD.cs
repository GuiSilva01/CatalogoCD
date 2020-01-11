using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Models
{
    public class CD
    {
        public int Id { get; set; }

        [Display(Name = "Album")]
        public string NomeCD { get; set; }

        [Display(Name = "Lancamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public DateTime DtLancamento { get; set; }

        public Gravadora Gravadora { get; set; }

        [Display(Name = "Gravadora")]
        public int GravadoraId { get; set; }

        
        public FaixadePreco FaixadePreco { get; set; }

        [Display(Name = "Faixa de Preco (Azul 10-30, Amarelo 30-60, Vermelho 60-120")]
        public int FaixadePrecoId { get; set; }

        public Musica Musica { get; set; }

        [Display(Name = "Musica")]
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
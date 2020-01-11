using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Models.ViewModels
{
    public class CDFormViewModel
    {
        public CD CD { get; set; }

        public ICollection<Gravadora> Gravadoras { get; set; }

        public ICollection<FaixadePreco> FaixadePrecos { get; set; }

        public ICollection<Musica> Musicas { get; set; }
    }
}

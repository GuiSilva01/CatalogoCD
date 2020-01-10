using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Models
{
    public class Gravadora
    {
        public int Id { get; set; }


        public string NomeGravadora { get; set; }


        public string Telefone { get; set; }


        public string Endereco { get; set; }

        public ICollection<CD> CDs { get; set; } = new List<CD>();

        public Gravadora()
        {

        }

        public Gravadora(int id, string nomeGravadora, string telefone, string endereco)
        {
            Id = id;
            NomeGravadora = nomeGravadora;
            Telefone = telefone;
            Endereco = endereco;
        }

        public void AddCD(CD cd)
        {
            CDs.Add(cd);
        }
    }
}
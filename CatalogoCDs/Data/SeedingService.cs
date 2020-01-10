using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogoCDs.Models;

namespace CatalogoCDs.Data
{
    public class SeedingService
    {
        private ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Metodo para popular o banco de dados
        public void Seed()
        {
            if (_context.Gravadora.Any() ||
                _context.FaixadePreco.Any() ||
                _context.Musica.Any() ||
                _context.CD.Any())
            {
                return;
            }

            Gravadora gr1 = new Gravadora(1, "BlackHits", "11955854558", "Av. Paulista 1522,São Paulo");
            Gravadora gr2 = new Gravadora(2, "Deckdisc", "15925587458", "Rua Eugenio 503, Minas");
            Gravadora gr3 = new Gravadora(3, "Digital Music", "11958745233", "Rua Mathues Gumoes 1000, São Paulo");
            Gravadora gr4 = new Gravadora(4, "Orbeat Music", "1195874412", "Av. Banderantes 2053, São Paulo");
            Gravadora gr5 = new Gravadora(5, "MK Music", "11925554788", "Rua Pablo Garcia, São Paulo");
            Gravadora gr6 = new Gravadora(6, "New Music", "11915863258", "Rua Alexandre Gand, São Paulo");

            FaixadePreco fp1 = new FaixadePreco(1, "Azul", 10.0, 30.0);
            FaixadePreco fp2 = new FaixadePreco(2, "Amarelo", 30.0, 60.0);
            FaixadePreco fp3 = new FaixadePreco(3, "Vermelho", 60.0, 120);

            Musica mc1 = new Musica(1, "Instagram", "Jay-Z");
            Musica mc2 = new Musica(2, "Bossa Nova at Carnegie Hall", "João Gilberto");
            Musica mc3 = new Musica(3, "Gota d'Água", "Chico Buarque");
            Musica mc4 = new Musica(4, "Proibido o Carnaval", "Caetano Veloso");
            Musica mc5 = new Musica(5, "Como Uma Onda", "Tim Maia");
            Musica mc6 = new Musica(6, "Iemanjá", "Gilberto Gil");
            Musica mc7 = new Musica(7, "Avôhai", "Zé Ramalho");
            Musica mc8 = new Musica(8, "Hoje é Dia de Festa ", "Zeca Pagodinho");
            Musica mc9 = new Musica(9, "O Melhor Vai Começar", "Guilherme Arantes");
            Musica mc10 = new Musica(10, "Eu te Devoro", "Djavan");
            Musica mc11= new Musica(11, "De uns tempos pra cá", "Lenine");
            Musica mc12= new Musica(12, "Quem Me Olha Só", "Arnaldo Antunes");
            Musica mc13= new Musica(13, "Os Mutantes", "Rita Lee");
            Musica mc14= new Musica(14, "O Rebu", "Raul Seixas");
            Musica mc15= new Musica(15, "Sanguinho Novo", "Arnaldo Baptista");
            Musica mc16= new Musica(16, "Equilíbrio Distante", "Renato Russo");
            Musica mc17= new Musica(17, "Vida Loka I", "Mano Brown");
            Musica mc18= new Musica(18, "Negro Drama", "Mano Brown");
            Musica mc19= new Musica(19, "Homem na Estrada", "Mano Brown");
            Musica mc20= new Musica(20, "Fórmula Mágica da Paz", "Mano Brown");
            Musica mc21= new Musica(21, "Fim de Semana no Parque", "Edi Rock");
            Musica mc22= new Musica(22, "Cirandeiro", "Maria Bethânia");
            Musica mc23= new Musica(23, "Sinherê", "Maria Bethânia");
            Musica mc24= new Musica(24, "Incerteza", "Antônio Carlos Jobim");
            Musica mc25= new Musica(25, "Eu Te Darei o Céu", "Roberto Carlos");
            Musica mc26= new Musica(26, "Esqueça", "Roberto Carlos");
            Musica mc27= new Musica(27, "De Que Vale Tudo Isso", "Roberto Carlos");
            Musica mc28= new Musica(28, "Fuckin", "Eminem");
            Musica mc29= new Musica(29, "Say What You Say", "Eminem");
            Musica mc30= new Musica(30, "Nigga What, Nigga Who", "Jay-Z");


            CD cd1 = new CD(1, "New Music", new DateTime(1998, 05, 05), gr6, fp3, mc2);
            CD cd2 = new CD(2, "BlackHits", new DateTime(2000, 05, 15), gr1, fp2, mc29);
            CD cd3 = new CD(3, "BlackHits", new DateTime(2000, 05, 15), gr1, fp2, mc28);
            CD cd4 = new CD(4, "Digital Music", new DateTime(2002, 10, 20), gr3, fp2, mc26);
            CD cd5 = new CD(5, "Orbeat Music", new DateTime(1998, 05, 05), gr4, fp1, mc17);
            CD cd6 = new CD(6, "Orbeat Music", new DateTime(1998, 05, 05), gr4, fp1, mc18);
            CD cd7 = new CD(7, "Orbeat Music", new DateTime(1998, 05, 05), gr4, fp1, mc19);
            CD cd8 = new CD(8, "Orbeat Music", new DateTime(1998, 05, 05), gr4, fp1, mc20);
            CD cd9 = new CD(9, "Orbeat Music", new DateTime(1998, 05, 05), gr4, fp1, mc21);

            _context.Gravadora.AddRange(gr1, gr2, gr3, gr4, gr5, gr6);

            _context.Musica.AddRange(
                mc1, mc2, mc3, mc4, mc5, mc6, mc7, mc8, mc9,
                mc10, mc11, mc12, mc13, mc14, mc15, mc16, mc17, mc18, mc19,
                mc20, mc21, mc22, mc23, mc24, mc25, mc26, mc27, mc28, mc29, mc30
                );

            _context.CD.AddRange(cd1, cd2, cd3, cd4, cd5, cd6, cd7, cd8, cd9);

            _context.SaveChanges();

        }

    }
}
using CatalogoCDs.Data;
using CatalogoCDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Services
{
    public class MusicaService
    {
        private readonly ApplicationDbContext _context;

        public MusicaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Musica> FindAll()
        {
            return _context.Musica.OrderBy(x => x.Id).ToList();
        }
    }
}

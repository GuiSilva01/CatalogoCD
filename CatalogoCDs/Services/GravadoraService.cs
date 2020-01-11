using CatalogoCDs.Data;
using CatalogoCDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Services
{
    public class GravadoraService
    {
        private readonly ApplicationDbContext _context;

        public GravadoraService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Gravadora> FindAll()
        {
            return _context.Gravadora.OrderBy(x => x.Id).ToList();
        }
    }
}

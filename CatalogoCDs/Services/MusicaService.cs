using CatalogoCDs.Data;
using CatalogoCDs.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Musica>> FindAllAsync()
        {
            return await _context.Musica.OrderBy(x => x.Id).ToListAsync();
        }
    }
}

using CatalogoCDs.Data;
using CatalogoCDs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoCDs.Services
{
    public class FaixadePrecoService
    {
        private readonly ApplicationDbContext _context;

        public FaixadePrecoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FaixadePreco>> FindAllAsync()
        {
            return await _context.FaixadePreco.OrderBy(x => x.Id).ToListAsync();
        }

        }
}

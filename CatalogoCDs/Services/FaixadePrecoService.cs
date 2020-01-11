﻿using CatalogoCDs.Data;
using CatalogoCDs.Models;
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

        public List<FaixadePreco> FindAll()
        {
            return _context.FaixadePreco.OrderBy(x => x.Id).ToList();
        }

        }
}

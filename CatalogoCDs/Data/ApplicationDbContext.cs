using System;
using System.Collections.Generic;
using System.Text;
using CatalogoCDs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CatalogoCDs.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CD> CD { get; set; }
        public DbSet<FaixadePreco> FaixadePreco { get; set; }
        public DbSet<Gravadora> Gravadora { get; set; }
        public DbSet<Musica> Musica { get; set; }
    }
}

using CatalogoCDs.Data;
using CatalogoCDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CatalogoCDs.Services
{
    // Depedencia do meu banco de dados
    public class CDService
    {
        private readonly ApplicationDbContext _context;

        public CDService(ApplicationDbContext context)
        {
            _context = context;
        }

        //Metodo que busca todos os CDs no banco ordenado por Faixa de Preco
        public List<CD> FindAll()
        {
            return _context.CD.Include(obj => obj.Musica).Include(obj => obj.FaixadePreco).OrderBy(x => x.FaixadePreco).ToList();
        }

        //Metodo para inserir um CD no banco
        public void Insert(CD obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        //Metodo para buscar por Id
        public CD FindById(int id)
        {
            return _context.CD.FirstOrDefault(obj => obj.Id == id);
        }

        //Metodo para Remover o obj do banco de dados por Id
        public void Remove(int id)
        {
            var obj = _context.CD.Find(id);
            _context.CD.Remove(obj);
            _context.SaveChanges();
        }
    }
}

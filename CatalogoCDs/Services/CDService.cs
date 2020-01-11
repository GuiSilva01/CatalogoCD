using CatalogoCDs.Data;
using CatalogoCDs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatalogoCDs.Services.Exceptions;

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
        public async Task<List<CD>> FindAllAsync()
        {
            return await _context.CD.Include(obj => obj.Musica).Include(obj => obj.FaixadePreco).Include(obj => obj.Gravadora).OrderBy(x => x.FaixadePreco).ToListAsync();
        }

        //Metodo para inserir um CD no banco
        public async Task InsertAsync(CD obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        //Metodo para buscar por Id
        public async Task<CD> FindByIdAsync(int id)
        {
            return await _context.CD.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        //Metodo para Remover o obj do banco de dados por Id
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.CD.FindAsync(id);
            _context.CD.Remove(obj);
            await _context.SaveChangesAsync();
        }

        //Metodo Update para editar um registro no banco
        public async Task UpdateAsync(CD obj)
        {
            bool hasAny = await _context.CD.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("O Id nao existe");
            }
            try { 
            _context.Update(obj);
            await _context.SaveChangesAsync();
            }
            //Tratamento da exception do nivel de acessos a dados para o nivel de servico
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}

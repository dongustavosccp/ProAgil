using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.Interfaces;
using ProAgil.Domain.Model;
using ProAgil.Repository.Data;

namespace ProAgil.Repository.Repositorios
{
    public class ProAgilPalestranteRepository : IProAgilPalestranteRepository
    {
        private readonly ProAgilContext _context;

        public ProAgilPalestranteRepository(ProAgilContext context)
        {
            _context = context;
        }

        public void Add(Palestrante entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Palestrante entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync(bool incluirEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(c => c.RedesSociais);

            if (incluirEventos)
            {
                query = query.Include(p => p.PalestrantesEventos)
                .ThenInclude(p => p.Evento);
            }

            query = query.OrderBy(c => c.Nome);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsyncById(int id, bool incluirEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(c => c.RedesSociais);

            if (incluirEventos)
            {
                query = query.Include(p => p.PalestrantesEventos)
                .ThenInclude(p => p.Evento);
            }

            query = query.Where(p => p.Id == id).OrderBy(c => c.Nome);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsyncByNome(string nome, bool incluirEventos = false)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(c => c.RedesSociais);

            if (incluirEventos)
            {
                query = query.Include(p => p.PalestrantesEventos)
                .ThenInclude(p => p.Evento);
            }

            query = query.Where(p => p.Nome.ToLower().Contains(nome.ToLower())).OrderBy(c => c.Nome);

            return await query.ToArrayAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Update(Palestrante entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
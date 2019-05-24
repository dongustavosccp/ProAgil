using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.Interfaces;
using ProAgil.Domain.Model;
using ProAgil.Repository.Data;

namespace ProAgil.Repository.Repositorios
{
    public class ProAgilEventoRepository : IProAgilEventoRepository
    {
        private readonly ProAgilContext _context;

        public ProAgilEventoRepository(ProAgilContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Add(Evento entity)
        {
            _context.Eventos.Add(entity);
        }

        public void Delete(Evento entity)
        {
            _context.Eventos.Remove(entity);
        }

        public async Task<Evento[]> GetAllEventoAsync(bool incluirPalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
              .Include(c => c.Lotes)
              .Include(c => c.RedesSociais);

            if (incluirPalestrantes)
            {
                query = query
                    .Include(pe => pe.PalestrantesEventos)
                    .ThenInclude(p => p.Palestrante);
            }

            query = query.AsNoTracking().OrderBy(c => c.Id);

            return await query.ToArrayAsync();

        }

        public async Task<Evento> GetAllEventoAsyncById(int id, bool incluirPalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
            .Include(c => c.Lotes)
            .Include(c => c.RedesSociais);

            if (incluirPalestrantes)
            {
                query = query.Include(p => p.PalestrantesEventos)
                .ThenInclude(p => p.Palestrante);
            }

            query = query.AsNoTracking().OrderBy(c => c.Id).Where(c => c.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool incluirPalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
            .Include(c => c.Lotes)
            .Include(c => c.RedesSociais);

            if (incluirPalestrantes)
            {
                query = query.Include(p => p.PalestrantesEventos)
                .ThenInclude(p => p.Palestrante);
            }

            query = query.Where(i => i.Tema.ToLower().Contains(tema.ToLower())).OrderByDescending(c => c.DataEvento);

            return await query.ToArrayAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Update(Evento entity)
        {
            _context.Eventos.Update(entity);
        }
    }
}
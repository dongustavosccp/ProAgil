using System.Threading.Tasks;
using ProAgil.Domain.Interfaces;
using ProAgil.Repository.Data;

namespace ProAgil.Repository.Repositorios
{
    public class ProAgilRepository<T> : IProAgilRepository<T> where T : class
    {
        private readonly ProAgilContext _context;

        public ProAgilRepository(ProAgilContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
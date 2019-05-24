using System.Threading.Tasks;

namespace ProAgil.Domain.Interfaces
{
    public interface IProAgilRepository<T>
    {
         void Add(T entity);
         
         void Update(T entity);
         
         void Delete(T entity);
         
         Task<bool> SaveChangesAsync();
    }
}
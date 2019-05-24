using System.Threading.Tasks;
using ProAgil.Domain.Model;

namespace ProAgil.Domain.Interfaces
{
    public interface IProAgilEventoRepository : IProAgilRepository<Evento>
    {
        Task<Evento[]> GetAllEventoAsyncByTema(string tema , bool incluirPalestrantes);
        Task<Evento> GetAllEventoAsyncById(int id, bool incluirPalestrantes);
        Task<Evento[]> GetAllEventoAsync(bool incluirPalestrantes);

    }
}
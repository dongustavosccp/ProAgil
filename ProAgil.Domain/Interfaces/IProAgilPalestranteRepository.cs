using System.Threading.Tasks;
using ProAgil.Domain.Model;

namespace ProAgil.Domain.Interfaces
{
    public interface IProAgilPalestranteRepository : IProAgilRepository<Palestrante>
    {
        Task<Palestrante[]> GetAllPalestrantesAsyncByNome(string nome, bool incluirEventos);
        Task<Palestrante[]> GetAllPalestrantesAsyncById(int id, bool incluirEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool incluirEventos);
    }
}
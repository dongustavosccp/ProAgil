using System.Threading.Tasks;
using ProAgil.Domain.Interfaces;
using ProAgil.Domain.Model;
using ProAgil.Domain.Model.Dto;

namespace ProAgil.Domain.Storers
{
    public class EventosStorer
    {
        private readonly IProAgilEventoRepository _proAgilEventoRepository;

        public EventosStorer(IProAgilEventoRepository proAgilEventoRepository)
        {
            _proAgilEventoRepository = proAgilEventoRepository;
        }

        public Task<Evento[]> GetAllEventoAsync(bool incluirPalestrantes)
        {
            return _proAgilEventoRepository.GetAllEventoAsync(incluirPalestrantes);
        }

        public Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool incluirPalestrantes)
        {
            return _proAgilEventoRepository.GetAllEventoAsyncByTema(tema, incluirPalestrantes);

        }

        public Task<Evento> GetAllEventoAsyncById(int id, bool incluirPalestrantes)
        {
            return _proAgilEventoRepository.GetAllEventoAsyncById(id, incluirPalestrantes);
        }

        public async Task<bool> Save(Evento evento)
        {
            _proAgilEventoRepository.Add(evento);

            return await _proAgilEventoRepository.SaveChangesAsync();
        }
    }
}
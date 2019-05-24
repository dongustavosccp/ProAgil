using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProAgil.Domain.Model;
using ProAgil.Domain.Model.Dto;
using ProAgil.Domain.Storers;
using System.Threading.Tasks;

namespace ProAgil.Api.Controllers
{
    [Route("api/[Controller]/")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private EventosStorer _eventoStorer;
        private IMapper _mapper;

        public EventoController(EventosStorer eventoStorer, IMapper mapper)
        {
            _eventoStorer = eventoStorer;
            _mapper = mapper;
        }

        //[HttpGet("{incluirPalestrante:bool}")]
        public async Task<IActionResult> Get()
        {
            var eventos = await _eventoStorer.GetAllEventoAsync(false);

            var results = _mapper.Map<EventoDto[]>(eventos);

            return Ok(eventos);
        }


        [HttpGet("{id:int}/{incluirPalestrante:bool}")]
        public async Task<IActionResult> Get(int id)
        {
            var evento = await _eventoStorer.GetAllEventoAsyncById(id, true);

            var eventoDto = _mapper.Map<EventoDto>(evento);

            return Ok(evento);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EventoDto eventoDto)
        {
            var evento = _mapper.Map<Evento>(eventoDto);

            return Ok(await _eventoStorer.Save(evento));
        }
    }
}
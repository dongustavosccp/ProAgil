using System.Collections.Generic;

namespace ProAgil.Domain.Model.Dto
{
    public class PalestranteDto : Entity
    {
        public string Nome { get; set; }
        public string MiniCurriculo { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public virtual List<RedeSocialDto> RedesSociais { get; set; }
        public virtual List<EventoDto> Eventos { get; set; }
    }
}
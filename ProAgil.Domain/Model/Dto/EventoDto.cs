using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.Domain.Model.Dto
{
    public class EventoDto : Entity
    {
        [Required(ErrorMessage = "Campo Obrigat�rio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Local � entre 3 e 100 Caracters")]
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O Tema deve ser Preeenchido")]
        public string Tema { get; set; }

        [Range(2, 120000, ErrorMessage = "Quatidade de Pessoas � entre 2 e 120000")]
        public int Quantidade { get; set; }
        public string ImagemURL { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public virtual List<LoteDto> Lotes { get; set; }
        public virtual List<RedeSocialDto> RedesSociais { get; set; }
        public virtual List<PalestranteDto> Palestrantes { get; set; }
    }
}
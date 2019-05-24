using System.ComponentModel.DataAnnotations;

namespace ProAgil.Domain.Model.Dto
{
    public class RedeSocialDto : Entity
    {
        
        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        public string URL { get; set; }
    }
}
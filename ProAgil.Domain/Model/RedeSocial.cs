namespace ProAgil.Domain.Model
{
    public class RedeSocial : Entity
    {
        public string Nome { get; set; }
        public string Url { get; set; }
        public int? EventoId { get; set; }
        public virtual Evento Evento { get; set; }
        public int? PalestranteId { get; set; }
        public virtual Palestrante Palestrante { get; set; }
    }
}
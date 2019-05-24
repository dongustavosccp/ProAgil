using System;
using System.Collections.Generic;
using ProAgil.Domain.Model.Dto;

namespace ProAgil.Domain.Model
{
    public class Evento : Entity
    {
        public string Local { get; private set; }
        public DateTime? DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int Quantidade { get; private set; }
        public string ImagemURL { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public virtual List<Lote> Lotes { get; set; }
        public virtual List<RedeSocial> RedesSociais { get; set; } 
        public virtual List<PalestranteEvento> PalestrantesEventos { get; private set; }

    }
}
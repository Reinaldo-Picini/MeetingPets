﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingsPets.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Fotos { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public DateTime Idade { get; set; }
        public string Vacina { get; set; }
        public string Porte { get; set; }
        public string Sexo { get; set; }
        public string Temperamento { get; set; }
        public string Descricao { get; set; }

    }
}
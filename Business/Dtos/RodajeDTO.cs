﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos
{
    public class RodajeDTO
    {
        public string Titulo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? Calificacion { get; set; }
        public int? idPersonaje { get; set; }
    }
}

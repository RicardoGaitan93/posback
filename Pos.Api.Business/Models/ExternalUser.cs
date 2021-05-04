using System;
using System.Collections.Generic;
using System.Text;

namespace Pos.Api.Business.Models
{
    public class ExternalUser
    {
        public int IdTercero { get; set; }
        public string NombreTercero { get; set; }
        public int TipoTercero { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacionTercero { get; set; }
        public string TelefonoTercero1 { get; set; }
        public string TelefonoTercero2 { get; set; }
        public string TelefonoTercero3 { get; set; }
        public string DireccionTercero1 { get; set; }
        public string DireccionTercero2 { get; set; }
        public string ObservacionTercero { get; set; }

    }
}

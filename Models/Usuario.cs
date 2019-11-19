using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public  class Usuario : Persona
    {
        public string ID_CARGO { get; set; }
        public string ID_PERFIL { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}

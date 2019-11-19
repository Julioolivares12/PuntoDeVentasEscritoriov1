using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public  class Usuario : Persona
    {
        public int ID_CARGO { get; set; }
        public int ID_PERFIL { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}

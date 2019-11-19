using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class LoginModel
    {
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string Email { get; set; }

        public string Perfil { get; set; }
        public string Cargo { get; set; }
    }
}

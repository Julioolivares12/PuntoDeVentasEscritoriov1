using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Cliente
    {
        public string ID { get; set; }
        public string PRIMERNOMBRE { get; set; }
        public string SEGUNDONOMBRE { get; set; }
        public string PRIMERAPELLIDO { get; set; }
        public string SEGUNDOAPELLIDO { get; set; }
        public string FECHANAC { get; set; }
        public string SEXO { get; set; }
        public string ESTADO_CIVIL { get; set; }
        public string LUGARTRABAJO { get; set; }
    }
}

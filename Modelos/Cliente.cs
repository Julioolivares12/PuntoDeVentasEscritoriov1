using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Cliente: Persona
    {
        public string LUGARTRABAJO { get; set; }
        public string DUI { get; set; }
        public string TEL_CASA { get; set; }
        public string TEL_TRABAJO { get; set; }
        public string CELULAR { get; set; }
        public string DIRECCIONCASA { get; set; }
        public string NIT { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Modelos
{
    public class Perfiles: BaseModel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}

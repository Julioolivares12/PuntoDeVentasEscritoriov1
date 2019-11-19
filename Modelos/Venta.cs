using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Venta
    {
        public int ID_VENTA { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_REPUESTOS { get; set; }
        public string NRODOC { get; set; }
        public string NRO_CF { get; set; }
        public string ID_TIPODOC { get; set; }
        public DateTime FECHAVENTA { get; set; }
        public double SUBTOTAL { get; set; }
        public double DESCUENTO { get; set; }
        public double IVA { get; set; }
        public double MONTOTOTAL { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public  class Repuesto : BaseModel
    {
        public int ID_PARTEVEH { get; set; }
        public int ID_MARCAVEH { get; set; }
        public string Nombe { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public double Descuento { get; set; }
        public string NumMotor { get; set; }
        public string NumChasis { get; set; }
        public string NumVin { get; set; }
        public string UPC { get; set; }
        public decimal Cantidad { get; set; }
    }
}

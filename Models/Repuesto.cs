﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
  public  class Repuesto : BaseModel
    {
        public string ID_PARTEVEH { get; set; }
        public string ID_MARCAVEH { get; set; }
        public string Nombe { get; set; }
        public string Descripcion { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public double Descuento { get; set; }
        public int NumMotor { get; set; }
        public int NumChasis { get; set; }
        public int NumVin { get; set; }
        public string UPC { get; set; }
        public decimal Cantidad { get; set; }
    }
}

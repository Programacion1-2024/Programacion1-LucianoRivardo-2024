﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public double MontoVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public string Pedido { get; set; }
    }
}

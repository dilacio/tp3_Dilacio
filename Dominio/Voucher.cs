﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public int ID { get; set; }
        public string CodigoVoucher { get; set; }
        public int Estado { get; set; }
        public int IDCliente { get; set; }
        public int IDProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}

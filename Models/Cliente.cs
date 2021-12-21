using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Cliente
    {
        public int NumCliente { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Correo { get; set; }
        public int Telefono { get; set; }
    }
}

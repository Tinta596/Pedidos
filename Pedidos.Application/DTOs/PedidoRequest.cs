using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Application.DTOs
{
    public class PedidoRequest
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}

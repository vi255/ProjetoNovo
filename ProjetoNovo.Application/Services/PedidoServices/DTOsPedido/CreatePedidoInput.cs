using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.PedidoServices.DTOsPedido
{
    public class CreatePedidoInput
    {
        public string NomeProduto { get; set; }

        public int PrazoEntrega { get; set; }
    }
}

using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.PedidoServices.DTOsPedido
{
    public class GetPedidoByIdOutput : EntityDto<long>
    {
        public string NomeProduto { get; set; }

        public int PrazoEntrega { get; set; }
    }
}

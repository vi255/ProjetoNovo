using ProjetoNovo.Services.PedidoServices.DTOsPedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace ProjetoNovo.Services.PedidoServices
{
    public interface IPedidoAppService
    {
        Task<CreatePedidoOutput> CreatePedido(CreatePedidoInput input);
        Task<UpdatePedidoOutput> UpdatePedido(UpdatePedidoInput input);
        Task DeletePedido(long id);
        Task<GetAllPedidoOutput> GetAllPedido();
    }
}

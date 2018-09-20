using Abp.Application.Services;
using ProjetoNovo.Services.ClienteServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.ClienteServices
{
    public interface IClienteAppService : IApplicationService
    {
        Task<CreateClienteOutput> CreateCliente(CreateClienteInput input);
        Task<UpdateClienteOutput> UpdateCliente(UpdateClienteInput input);
        Task DeleteCliente(long id);
        Task<GetClienteByIdOutput> GetByIdCliente(long id);
        Task<GetAllClienteOutput> GetAllCliente();
        Task VincularPedido(long clienteId, long pedidoId);
    }
}

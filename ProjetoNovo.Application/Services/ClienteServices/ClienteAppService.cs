using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using ProjetoNovo.Entities.ClienteEntity;
using ProjetoNovo.Entities.ClienteEntity.Manager;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.PedidoEntity.Manager;
using ProjetoNovo.Entities.TelefoneEntity;
using ProjetoNovo.Services.ClienteServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.ClienteServices
{
    public class ClienteAppService : ApplicationService, IClienteAppService
    {
        private IClienteManager _clienteManager;
        private IPedidoManager pedidoManager;

        public ClienteAppService(IClienteManager clienteManager, IPedidoManager _pedidoManager)
        {
            _clienteManager = clienteManager;
            pedidoManager = _pedidoManager;
        }

        public async Task<CreateClienteOutput> CreateCliente(CreateClienteInput input)
        {
            var cliente = input.MapTo<Cliente>();
            var retorno = await _clienteManager.Create(cliente);
            return new CreateClienteOutput
            {
                Id = retorno
            };
        }

        public async Task DeleteCliente(long id)
        {
            await _clienteManager.Delete(id);
        }

        public async Task<GetAllClienteOutput> GetAllCliente()
        {
            var cliente = await _clienteManager.GetAllList();
            return new GetAllClienteOutput { Cliente = Mapper.Map<List<GetAllClienteItem>>(cliente) };

        }

        public async Task<GetClienteByIdOutput> GetByIdCliente(long id)
        {
            var cliente = await _clienteManager.GetByIdCliente(id);
            return cliente.MapTo<GetClienteByIdOutput>();

        }

        public async Task<UpdateClienteOutput> UpdateCliente(UpdateClienteInput input)
        {

            var cliente = input.MapTo<Cliente>();
            var clienteAtualizado = await _clienteManager.Update(cliente);
            return clienteAtualizado.MapTo<UpdateClienteOutput>();
        }

        public async Task VincularPedido(long clienteId, long pedidoId)
        {
            var cliente = await _clienteManager.GetByIdCliente(clienteId);
            var pedido = await pedidoManager.GetByIdPedido(pedidoId);

            await _clienteManager.VincularPedido(cliente, pedido);
        }

    }
}

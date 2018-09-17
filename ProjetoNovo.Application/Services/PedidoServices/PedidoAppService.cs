using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using ProjetoNovo.Entities.PedidoEntity;
using ProjetoNovo.Entities.PedidoEntity.Manager;
using ProjetoNovo.Services.PedidoServices.DTOsPedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.PedidoServices
{
    public class PedidoAppService : ApplicationService, IPedidoAppService
    {
        private IPedidoManager _pedidoManager;

        public PedidoAppService(IPedidoManager pedidoManager)
        {
            _pedidoManager = pedidoManager;
        }


        public async Task<CreatePedidoOutput> CreatePedido(CreatePedidoInput input)
        {
            var pedido = input.MapTo<Pedido>();
            var createdPedidoId = await _pedidoManager.Create(pedido);

            return new CreatePedidoOutput
            {
                Id = createdPedidoId
            };
        }

        public async Task DeletePedido(long id)
        {
            await _pedidoManager.Delete(id);
        }

        public async Task<GetAllPedidoOutput> GetAllPedido()
        {
            var pedido = await _pedidoManager.GetAllList();
            return new GetAllPedidoOutput { Pedido = Mapper.Map<List<GetAllPedidoId>>(pedido) };
        }


        public async Task<UpdatePedidoOutput> UpdatePedido(UpdatePedidoInput input)
        {
            var pedido = input.MapTo<Pedido>();
            var pedidoAtualizado = await _pedidoManager.Update(pedido);
            return pedidoAtualizado.MapTo<UpdatePedidoOutput>();
        }
    }
}

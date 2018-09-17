using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.PedidoEntity.Manager
{
    public class PedidoManager : IDomainService, IPedidoManager
    {
        private IRepository<Pedido, long> _pedidoRepository;

        public PedidoManager(IRepository<Pedido, long> pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<long> Create(Pedido pedido)
        {
            return await _pedidoRepository.InsertAndGetIdAsync(pedido);
        }

        public async Task Delete(long id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }

        public async Task<List<Pedido>> GetAllList()
        {
            return await _pedidoRepository.GetAllListAsync();
        }

        public async Task<Pedido> GetById(long id)
        {
            return await _pedidoRepository.GetAsync(id);
        }

        public async Task<Pedido> Update(Pedido pedido)
        {
            return await _pedidoRepository.UpdateAsync(pedido);
        }
    }
}

using Abp.Domain.Repositories;
using Abp.Domain.Services;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.PedidoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.ClienteEntity.Manager
{
    public class ClienteManager : IDomainService, IClienteManager
    {
        private IClienteRepository _clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<long> Create(Cliente cliente)
        {
            return await _clienteRepository.InsertAndGetIdAsync(cliente);
        }

        public async Task Delete(long id)
        {
            await _clienteRepository.DeleteAsync(id);
        }

        public async Task<List<Cliente>> GetAllList()
        {
            return await Task.Run(() => _clienteRepository.GetAllIncluding(x => x.Documento, y => y.Telefones).ToList());
        }

        public async Task<Cliente> GetByIdCliente(long id)
        {
            return await Task.Run(() => _clienteRepository.GetAllIncluding(x => x.Documento, y => y.Telefones, z => z.Pedidos).Where(x=> x.Id == id).FirstOrDefault());

        }

        public async Task<Cliente> Update(Cliente cliente)
        {
            return await _clienteRepository.UpdateAsync(cliente);
        }

        public async Task VincularPedido(Cliente cliente, Pedido pedido)
        {
            await _clienteRepository.Add(cliente, pedido);

        }
    }
}

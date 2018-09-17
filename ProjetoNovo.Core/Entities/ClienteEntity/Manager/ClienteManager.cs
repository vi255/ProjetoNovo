using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.ClienteEntity.Manager
{
    public class ClienteManager : IDomainService, IClienteManager
    {
        private IRepository<Cliente, long> _clienteRepository;

        public ClienteManager(IRepository<Cliente, long> clienteRepository)
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
            return await _clienteRepository.GetAllListAsync();
        }

        public async Task<Cliente> GetById(long id)
        {
            return await _clienteRepository.GetAsync(id);
        }

        public async Task<Cliente> Update(Cliente cliente)
        {
            return await _clienteRepository.UpdateAsync(cliente);
        }
    }
}

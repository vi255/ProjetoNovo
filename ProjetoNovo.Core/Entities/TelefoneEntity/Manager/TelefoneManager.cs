using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.TelefoneEntity.Manager
{
    public class TelefoneManager : IDomainService, ITelefoneManager
    {
        private IRepository<Telefone, long> _telefoneRepository;

        public TelefoneManager(IRepository<Telefone, long> telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        public async Task<long> Create(Telefone telefone)
        {
            return await _telefoneRepository.InsertAndGetIdAsync(telefone);
        }

        public async Task Delete(long id)
        {
            await _telefoneRepository.DeleteAsync(id);
        }

        public async Task<List<Telefone>> GetAllList()
        {
            return await _telefoneRepository.GetAllListAsync();
        }

        public async Task<Telefone> GetById(long id)
        {
            return await _telefoneRepository.GetAsync(id);
        }

        public async Task<Telefone> Update(Telefone telefone)
        {
            return await _telefoneRepository.UpdateAsync(telefone);
        }
    }
}

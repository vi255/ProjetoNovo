using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.DocumentoEntity.Manager
{
    public class DocumentoManager : IDomainService, IDocumentoManager
    {
        private IRepository<Documento, long> _documentoRepository;

        public DocumentoManager(IRepository<Documento, long> documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }

        public async Task<long> Create(Documento documento)
        {
            return await _documentoRepository.InsertAndGetIdAsync(documento);
        }

        public async Task Delete(long id)
        {
            await _documentoRepository.DeleteAsync(id);
        }

        public async Task<List<Documento>> GetAllList()
        {
            return await _documentoRepository.GetAllListAsync();
        }

        public async Task<Documento> GetById(long id)
        {
            return await _documentoRepository.GetAsync(id);
        }

        public async Task<Documento> Update(Documento documento)
        {
            return await _documentoRepository.UpdateAsync(documento);
        }
    }
}

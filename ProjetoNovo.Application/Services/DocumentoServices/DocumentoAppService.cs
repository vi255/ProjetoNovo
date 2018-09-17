using Abp.Application.Services;
using Abp.AutoMapper;
using AutoMapper;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.DocumentoEntity.Manager;
using ProjetoNovo.Services.DocumentoServices.DTOsDocumento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.DocumentoServices
{
    public class DocumentoAppService : ApplicationService, IDocumentoAppService
    {
        private IDocumentoManager _documentoManager;

        public DocumentoAppService(IDocumentoManager documentoManager)
        {
            _documentoManager = documentoManager;
        }

        public async Task<CreateDocumentoOutput> CreateDocumento(CreateDocumentoInput input)
        {
            var documento = input.MapTo<Documento>();
            var createdDocumentoId = await _documentoManager.Create(documento);

            return new CreateDocumentoOutput
            {
                Id = createdDocumentoId
            };
        }

        public async Task DeleteDocumento(long id)
        {
            await _documentoManager.Delete(id);
        }

        public async Task<GetAllDocumentoOutput> GetAllDocumento()
        {
            var documento = await _documentoManager.GetAllList();
            return new GetAllDocumentoOutput { Documento = Mapper.Map<List<GetAllDocumentoId>>(documento) };
        }


        public async Task<UpdateDocumentoOutput> UpdateDocumento(UpdateDocumentoInput input)
        {
            var documento = input.MapTo<Documento>();
            var documentoAtualizado = await _documentoManager.Update(documento);
            return documentoAtualizado.MapTo<UpdateDocumentoOutput>();
        }
    }
}

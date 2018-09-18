using Abp.Application.Services.Dto;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.TelefoneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.ClienteServices.DTOs
{
    public class GetClienteByIdOutput : EntityDto<long>
    {
        public string Name { get; set; }
        [DefaultValue("Ativo")]
        public string Status { get; set; }
        public Documento Documento { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}

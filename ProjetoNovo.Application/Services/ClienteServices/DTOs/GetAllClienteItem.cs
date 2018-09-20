using Abp.Application.Services.Dto;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.PedidoEntity;
using ProjetoNovo.Entities.TelefoneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.ClienteServices.DTOs
{
    public class GetAllClienteItem : EntityDto<long>
    {
        public string Name { get; set; }
        [DefaultValue("Ativo")]
        public string Status { get; set; }
        public long DocumentoId { get; set; }
        public Documento Documento { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}

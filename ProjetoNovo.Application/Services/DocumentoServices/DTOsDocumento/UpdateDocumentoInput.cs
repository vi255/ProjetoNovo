using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Services.DocumentoServices.DTOsDocumento
{
   public class UpdateDocumentoInput : EntityDto<long>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
    }
}

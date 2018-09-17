using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.DocumentoEntity
{
    public class Documento : FullAuditedEntity<long>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public Documento()
        {
            CreationTime = DateTime.Now;
        }

        public Documento(string tipoDocumento, string numDocumento)
        {
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numDocumento;

        }
    }
}

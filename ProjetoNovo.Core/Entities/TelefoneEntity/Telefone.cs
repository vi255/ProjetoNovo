using Abp.Domain.Entities.Auditing;
using ProjetoNovo.Entities.ClienteEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.TelefoneEntity
{
    public class Telefone : FullAuditedEntity<long>
    {
        
        public int NumeroTelefone { get; set; }
        public string TipoTelefone { get; set; }
        public long ClienteId { get; set; }
        public Cliente Cliente;

        //Construtores
        public Telefone()
        {
            CreationTime = DateTime.Now;
        }

        public Telefone(int numeroTel, string tipoTel, int clienteId)
        {
            CreationTime = DateTime.Now;
            NumeroTelefone = numeroTel;
            TipoTelefone = tipoTel;
            ClienteId = clienteId;
        }
    }
}

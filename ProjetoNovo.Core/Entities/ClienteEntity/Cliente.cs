using Abp.Domain.Entities.Auditing;
using ProjetoNovo.Entities.DocumentoEntity;
using ProjetoNovo.Entities.PedidoEntity;
using ProjetoNovo.Entities.TelefoneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.ClienteEntity
{
    public class Cliente : FullAuditedEntity<long>
    {
        public string Name { get; set; }
        [DefaultValue("Ativo")]
        public string Status { get; set; }
        public Documento Documento { get; set; }
        public List<Telefone> Telefones { get; }
        public ICollection<Pedido> Pedidos { get; set; }

        //Construtores
        public Cliente()
        {
            CreationTime = DateTime.Now;
        }

        public Cliente(string name, string status, Documento doc, List<Telefone> tel)
        {
            CreationTime = DateTime.Now;
            Name = name;
            Status = status;
            Documento = doc;
            Telefones = tel;
        }
    }
}

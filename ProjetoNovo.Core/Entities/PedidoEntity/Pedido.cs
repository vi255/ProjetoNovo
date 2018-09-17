using Abp.Domain.Entities.Auditing;
using ProjetoNovo.Entities.ClienteEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNovo.Entities.PedidoEntity
{
    public class Pedido : FullAuditedEntity<long>
    {
        public string NomeProduto { get; set; }
        public int PrazoEntrega { get; set; }
        public ICollection<Cliente> Clientes { get; set; }

        //Construtores
        public Pedido()
        {
            CreationTime = DateTime.Now;
        }

        public Pedido(string nomeProd, int prazoEntrega)
        {
            CreationTime = DateTime.Now;
            NomeProduto = nomeProd;
            PrazoEntrega = prazoEntrega;
        }
    }
}

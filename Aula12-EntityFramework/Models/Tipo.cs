using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aula12_EntityFramework.Models
{
    [Table("Tipos")]
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Nome { get; set; }

        //Essa propriedade é porque há uma chave estrangeira
        public List<Cliente> Clientes { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula07_Model.Models
{
    public class Cliente
    {
        //Este é meu modelo de dominio
        public int CliendId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
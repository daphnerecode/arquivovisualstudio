using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaCrud.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ID { get; set;}
       
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; } 
        public int Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Dataida { get; set; }
        public DateTime Dataretorno { get; set; }
        public string Destino { get; set; }
    }

}

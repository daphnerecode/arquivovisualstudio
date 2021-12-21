using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaCrud.Models
{
    [Table ("Reserva")]

    public class Reserva
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Dataida { get; set; }
        public DateTime Dataretorno { get; set; }
        public string Destino { get; set; }
        public int Numerodiarias { get; set; }
        public int Valortotal { get; set; }
    }
}

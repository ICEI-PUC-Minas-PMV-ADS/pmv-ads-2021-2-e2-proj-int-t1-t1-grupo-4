using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Tipos")]
    public class Tipo
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}

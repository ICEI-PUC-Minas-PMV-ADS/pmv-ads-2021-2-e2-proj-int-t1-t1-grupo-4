using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Usuarios_Receitas")]
    public class Usuario_Receita
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public int ReceitaId { get; set; }
       
        public Receita Receita { get; set; }

    }
}

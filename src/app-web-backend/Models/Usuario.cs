using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }  
        
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório!")]
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Avatar { get; set; }
        public bool EstaLogado { get; set; }

        public List<Usuario_Receita> Usuario_Receitas { get; set; }
    }
}

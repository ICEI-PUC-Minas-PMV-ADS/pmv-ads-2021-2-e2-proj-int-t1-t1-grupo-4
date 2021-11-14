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

        [Required(ErrorMessage = "Por favor, informe o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o e-mail!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [NotMapped]
        [Display(Name ="Confirme sua senha")]
        [Required(ErrorMessage = "Confirme sua senha!")]
        [Compare("Senha", ErrorMessage = "A senha deve ser igual nos dois campos.")]
        public string ConfirmaSenha { get; set; }
        

        public string Avatar { get; set; }
        public bool EstaLogado { get; set; }
        
        public Perfil Perfil { get; set; }
        public List<Usuario_Receita> Usuario_Receitas { get; set; }
    }

    public enum Perfil
    {
        Administrador,
        Usuario
    }
}

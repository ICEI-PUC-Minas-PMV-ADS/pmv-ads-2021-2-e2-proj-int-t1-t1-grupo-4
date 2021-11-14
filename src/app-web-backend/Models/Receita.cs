using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Receitas")]
    public class Receita
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Ingrediente Principal")]
        [Required(ErrorMessage = "É obrigatório informar o ingrediente principal!")]
        public string IngredientePrincipal { get; set; }

        [Display(Name = "Tempo de Preparo")]
        [Required(ErrorMessage = "É obrigatório informar o tempo de preparo!")]
        public long TempoPreparo { get; set; }

        [Display(Name = "Modo de Preparo")]
        [Required(ErrorMessage = "É obrigatório informar o modo de preparo!")]
        public string ModoPreparo { get; set; }
        public int Autor { get; set; }
        public string Imagem { get; set; }
        public int ContadorFavoritos { get; set; }
        public List<Usuario_Receita> Usuario_Receitas { get; set; }
    }
}

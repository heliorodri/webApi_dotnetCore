using System.ComponentModel.DataAnnotations;

namespace primeira_api.models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MaxLength(60, ErrorMessage = "O campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "O campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; set; }
        
    }
}
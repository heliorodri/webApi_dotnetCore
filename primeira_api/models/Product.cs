using System.ComponentModel.DataAnnotations;

namespace primeira_api.models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MaxLength(60, ErrorMessage = "O campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "O campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "o campo deve conter no máximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
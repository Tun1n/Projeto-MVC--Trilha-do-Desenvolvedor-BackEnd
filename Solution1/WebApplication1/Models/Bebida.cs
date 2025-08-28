using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Bebidas")]
    public class Bebida
    {
        [Key]
        public int BebidaId { get; set; }

        [Required(ErrorMessage = "O nome da bebida deve ser informada")]
        [Display(Name = "Nome da Bebida")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O nome deve ter de 10 a 200 caracteres")]

        public string Name { get; set; }

        [Required(ErrorMessage = "A descrição da bebida deve ser informada")]
        [Display(Name = "Descrição da Bebida")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres")]
        [MaxLength(2000, ErrorMessage = "A descrição deve ter no máximo 2000 caracteres")]

        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada da bebida deve ser informada")]
        [Display(Name = "Descrição detalhada da Bebida")]
        [MinLength(20, ErrorMessage = "A descrição detalhada deve ter no mínimo 20 caracteres")]
        [MaxLength(2000, ErrorMessage = "A descrição detalhada deve ter no máximo 2000 caracteres")]

        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço da bebida")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]

        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(2000, ErrorMessage = "O tamanho máximo é 2000 caracteres")]

        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Thumbnail")]
        [StringLength(2000, ErrorMessage = "O tamanho máximo é 2000 caracteres")]

        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferida?")]

        public bool IsBebidaPreferida { get; set; }

        [Display(Name = "Estoque")]

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}

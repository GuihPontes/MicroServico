using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Produtos")]
    public class ProductModel : BaseEntity
    {
       
        public ProductModel(string nome, decimal preco, string descricao, string categoria, string imagemURL)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Categoria = categoria;
            ImagemURL = imagemURL;
        }

        [Column("Nome")]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Column("Preco")]
        [Required]
        [Range(1,10000)]
        public decimal Preco { get; set; }

        [Column("Descricao")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Column("Categoria")]
        [StringLength(50)]
        public string Categoria { get; set; }

        [Column("Favorito")]
        [Required]
        
        public bool IsFavorito { get; set; }

        [Column("ImagemURL")]
        [Required]
        // URL so funciona até 255 caracters
        [StringLength(300)]
        public string ImagemURL { get; set; }


    }
}

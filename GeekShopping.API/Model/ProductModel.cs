using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Produtos")]
    public class ProductModel : BaseEntity
    {
        public ProductModel()
        {

        }
        public ProductModel(string nome, decimal preco, string descricao, string categoria,string url) 
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Categoria = categoria;
            URL = url;
           
        }

        [Column("Nome")]
        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Column("Preco")]
        [Required]
        [Range(1,10000)]
        public decimal? Preco { get; set; }

        [Column("Descricao")]
        [StringLength(500)]
        public string? Descricao { get; set; }

        [Column("Categoria")]
        [StringLength(50)]
        public string? Categoria { get; set; }


        [Column("URL")]
        [StringLength(300)]
        public string? URL  { get; set; }

   


    }
}

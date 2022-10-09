namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public ProductVO(long id, string nome, decimal preco, string descricao, string categoria, bool isFavorito, string imageUrl)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Categoria = categoria;
            IsFavorito = isFavorito;
            ImageUrl = imageUrl;
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public bool IsFavorito { get; set; }
        public string ImageUrl { get; set; }

    }
}

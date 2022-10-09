namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        public ProductVO()
        {

        }
        public ProductVO(long id, string nome, decimal preco, string descricao, string categoria, string url)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
            Categoria = categoria;
            URL = url;
            
        }

        public long? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public string? Descricao { get; set; }
        public string? Categoria { get; set; }
        public string? URL { get; set; }

    

    }
}

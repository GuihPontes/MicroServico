using GeekShopping.ProductAPI.Data.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> BuscarTodos();
        Task<ProductVO> BuscarProduto(long id);
        Task<ProductVO> Criar(ProductVO product);
        Task<ProductVO> Atulizar(ProductVO product);
        Task<bool> Deletar(long id);

    }
}

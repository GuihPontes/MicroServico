using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProdutoServices
    {
        Task<IEnumerable<ProdutoModel>> BuscaTodos();
        Task<ProdutoModel> BuscaProduto(long id);
        Task<ProdutoModel> Criar(ProdutoModel produto);
        Task<ProdutoModel> Atualizar(ProdutoModel produto);
        Task<bool> Deletar(long id);
    }
}

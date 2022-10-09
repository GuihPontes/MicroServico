using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Util;
namespace GeekShopping.Web.Services
{
    public class ProdutoServices : IProdutoServices
    {
       private readonly HttpClient _client;
        public const string BasePath = "api/v1/produto";

        public ProdutoServices(HttpClient client)
        {
            _client = client;
        }

        public async Task<ProdutoModel> BuscaProduto(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProdutoModel>();
        }

        public async Task<IEnumerable<ProdutoModel>> BuscaTodos()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProdutoModel>>();
        }

        public async Task<ProdutoModel> Criar(ProdutoModel produto)
        {
            var response = await _client.PostAsJason(BasePath, produto);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProdutoModel>();
            else throw new Exception("Deu algo errado na comunicação");

        }
        public async Task<ProdutoModel> Atualizar(ProdutoModel produto)
        {
            var response = await _client.PutAsJason(BasePath, produto);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<ProdutoModel>();
            else throw new Exception("Deu algo errado na comunicação");
        }
        public async Task<bool> Deletar(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<bool>();
            else throw new Exception("Deu algo errado na comunicação");
        }
    }
}

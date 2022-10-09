using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private IProductRepository _repository;

        public ProdutosController(IProductRepository repository)
        {
            _repository = repository 
                                    ?? 
                                    throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet]
            public async Task<ActionResult<IEnumerable<ProductVO>>> BuscarTodos()
        {
            var prdouto = await _repository.BuscarTodos();
            if (prdouto == null) return NotFound();
            return Ok(prdouto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> BuscaProduto(int id)
        {
            var prdouto = await _repository.BuscarProduto(id);
            if (prdouto == null) return NotFound();
            return Ok(prdouto);
        }

        [HttpPost]
        public async Task <ActionResult<ProductVO>> Criar(ProductVO produto)
        {
            if(produto == null) return BadRequest();
            var product = await _repository.Criar(produto);
            return Ok(produto);
        }
        [HttpPut]
        public async Task<ActionResult<ProductVO>> Atualizar(ProductVO produto)
        {
            if (produto == null) return BadRequest();
            var product = await _repository.Atulizar(produto);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Deletar(long id)
        {
            var status = await _repository.Deletar(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}

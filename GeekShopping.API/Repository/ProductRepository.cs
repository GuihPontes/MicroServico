using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlContext _context;
        private IMapper  _mapper;

        public ProductRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

  

        public async Task<IEnumerable<ProductVO>> BuscarTodos()
        {
            var products = await _context.Produtos.ToListAsync();
            return  _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> BuscarTodos(long id)
        {
            var productus = await _context.Produtos.
                                                    Where(p=>p.Id == id).
                                                    FirstOrDefaultAsync();

           return _mapper.Map<ProductVO>(productus);

        }

        public async Task<ProductVO> Criar(ProductVO vo)
        {
            ProductModel produto = _mapper.Map<ProductModel>(vo);
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(produto);
        }
        public async Task<ProductVO> Atulizar(ProductVO vo)
        {
            ProductModel produto = _mapper.Map<ProductModel>(vo);
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(produto);
        }

        public async Task<bool> Deletar(long id)
        {
            try
            {
                var productus = await _context.Produtos.
                                                   Where(p => p.Id == id).
                                                   FirstOrDefaultAsync();

                if (productus == null) return false;

                _context.Produtos.Remove(productus);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception) 
            {
                return false;
            }
        }
    }
}

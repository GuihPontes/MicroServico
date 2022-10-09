using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration Mapper()
        {
            var mappeamentoConfig = new MapperConfiguration(mapper =>
            {
                mapper.CreateMap<ProductVO, ProductModel>();
                mapper.CreateMap<ProductModel, ProductVO>();
            });

            return mappeamentoConfig;
        }
    }
}

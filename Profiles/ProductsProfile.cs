using AutoMapper;
using FlowerStoreAPI.Dtos;
using FlowerStoreAPI.Models;

namespace FlowerStoreAPI.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            //Source -> Target
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
        }
    }
}
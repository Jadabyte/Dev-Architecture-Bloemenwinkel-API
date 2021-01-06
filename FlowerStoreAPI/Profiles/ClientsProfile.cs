using AutoMapper;
using FlowerStoreAPI.Dtos;
using FlowerStoreAPI.Models;

namespace FlowerStoreAPI.Profiles
{
    public class ClientsProfile : Profile
    {
        public ClientsProfile()
        {
            //Source -> Target
            CreateMap<Client, ClientReadDto>();
            CreateMap<ClientCreateDto, Client>();
        }
    }
}
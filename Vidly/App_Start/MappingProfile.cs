using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Permitindo que um Customer possa ser mapeado para CustomerDto e vice-versa.
            Mapper.CreateMap<Customer, CustomerDto>();
            // O Id está sendo ignorado para não dar erro ao realizar o Update, pois tentará mudar o Id.
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            // Permitindo que um Movie possa ser mapeado para MovieDto e vice-versa.
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}
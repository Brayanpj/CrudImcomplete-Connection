using AutoMapper;
using Pro.Infra.Dtos;
using Pro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioAPIPro.Profiles
{
    public class UsuáriosProfile : Profile
    {  
        public UsuáriosProfile()
        {
            CreateMap<CreateUsuarioDto, UsuarioKey>();
            CreateMap<UsuarioKey, ReadUsuarioDto>();
            CreateMap<UpdateUsuarioDto, UsuarioKey>();


        }

    }
}

using System;
using AutoMapper;
using Mallify.API.Models;
using Mallify.API.Resources;

namespace Mallify.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}

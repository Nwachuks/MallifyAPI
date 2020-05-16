using System;
using AutoMapper;
using Mallify.API.Models;
using Mallify.API.Resources;

namespace Mallify.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}

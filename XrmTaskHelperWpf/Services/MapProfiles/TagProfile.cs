using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using XrmTaskHelper.Domain.Entities;

namespace XrmTaskHelperWpf.Services.MapProfiles
{
    public class TagProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Tag, Tag>();
        }
    }
}

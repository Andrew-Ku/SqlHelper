using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelperWpf.ViewModels;
using System;
using System.Linq;
using System.Linq.Expressions;

using AutoMapper;


namespace XrmTaskHelperWpf.Services.MapProfiles
{
    public class XrmTaskProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<XrmTask, XrmTask>();
            CreateMap<XrmTask, XrmTaskVm>()
                .ForMember(d => d.Items, s => s.MapFrom(o => o.Items.Select(Mapper.Map<XrmTaskItem, XrmTaskItemVm>)));
            CreateMap<XrmTaskVm, XrmTask>();
        }
    }
}

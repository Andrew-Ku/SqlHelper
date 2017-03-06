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
//                .ForMember(d => d.Items, s => s.MapFrom(o => o.Items.Select(Mapper.Map<XrmTaskItem, XrmTaskItemVm>)))
                .ForMember(d => d.Items, s => s.Ignore())
                .ForMember(d => d.CreateDate, s => s.MapFrom(o => o.CreateDate.ToShortDateString()))
                .ForMember(d => d.CompleteDate, s => s.MapFrom(o => o.CompleteDate.HasValue ? o.CompleteDate.Value.ToShortDateString() : ""));

            CreateMap<XrmTaskVm, XrmTask>();
        }
    }
}

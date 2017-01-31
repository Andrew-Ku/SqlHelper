using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelperWpf.ViewModels;

namespace XrmTaskHelperWpf.Services.MapProfiles
{
    public class XrmTaskItemProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<XrmTaskItem, XrmTaskItem>();
            CreateMap<XrmTaskItem, XrmTaskItemVm>();
            CreateMap<XrmTaskItemVm, XrmTaskItem>();
        }
    }
}

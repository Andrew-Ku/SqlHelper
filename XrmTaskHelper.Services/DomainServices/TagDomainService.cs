﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Domain.Entities;
using XrmTaskHelper.Domain.Interfaces;

namespace XrmTaskHelper.Services.DomainServices
{
    public class TagDomainService: BaseDomainService<Tag>
    {
        public TagDomainService(IRepository<Tag> repository) : base(repository)
        {
        }
    }
}
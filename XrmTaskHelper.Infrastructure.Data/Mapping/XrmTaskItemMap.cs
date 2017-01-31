﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Domain.Entities;

namespace XrmTaskHelper.Infrastructure.Data.Mapping
{
    public class XrmTaskItemMap : EntityTypeConfiguration<XrmTaskItem>
    {
        public XrmTaskItemMap()
        {
            ToTable("dmTasks");
        }
    }
}
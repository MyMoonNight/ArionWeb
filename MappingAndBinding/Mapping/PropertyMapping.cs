﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class PropertyMapping : BaseStringEntityMapping<Property>
    {
        public PropertyMapping()
            : base()
        {
            ToTable("Properties");

            Property(e => e.PropertyType).IsOptional();
            Property(e => e.Key).IsOptional();
            Property(e => e.Min).IsOptional();
            Property(e => e.Max).IsOptional();
            Property(e => e.Default).IsOptional();
            Property(e => e.Visible).IsRequired();

            HasMany(e => e.Descriptions);
            HasMany(e => e.Keys);
        }
    }
}

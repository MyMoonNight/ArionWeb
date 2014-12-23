﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class ElementClassMapping : BaseStringEntityMapping<ElementClass>
    {
        public ElementClassMapping() 
            : base()
        {
            ToTable("ElementClasses");

            HasMany(e => e.Positions);
        }
    }
}

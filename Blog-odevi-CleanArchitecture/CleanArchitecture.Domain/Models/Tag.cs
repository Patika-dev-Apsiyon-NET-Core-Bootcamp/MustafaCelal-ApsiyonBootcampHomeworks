﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models
{
    public class Tag:Entity
    {
        public string Name { get; set; }
        public virtual Blog Blog { get; set; }
    }
}

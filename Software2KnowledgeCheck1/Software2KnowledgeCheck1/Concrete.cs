﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Concrete : Materials
    {
        internal override string MaterialConstructionFirstStep()
        {
            return "Start laying foundation";
        }
    }
}

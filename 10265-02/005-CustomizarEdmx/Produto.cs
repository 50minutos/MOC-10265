﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_CustomizarEdmx
{
    partial class Produto
    {
        public override string ToString()
        {
            return String.Format("{0} -> {1}", Id, Nome);
        }
    }
}

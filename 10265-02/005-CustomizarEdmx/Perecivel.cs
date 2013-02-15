using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_CustomizarEdmx
{
    partial class Perecivel
    {
        public override string ToString()
        {
            return String.Format("{0} - {1:d}", base.ToString(), Vencimento);
        }

    }
}

using System;
using System.Diagnostics;

namespace _000_AW
{
    partial class Contato
    {
        partial void OnNomeChanged()
        {
            Debug.Print("o nome foi alterado para {0}", Nome);
        }

        partial void OnNomeChanging(String value)
        {
            Trace.Assert(!String.IsNullOrEmpty(value), "O nome não pode ser null ou string de comprimento zero");

            Debug.Print("o nome está sendo alterado de {0} para {1}", Nome, value);
        }
    }
}

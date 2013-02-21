using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_GerarChaveSimetrica
{
    public static class ByteArrayExtension
    {
        public static String GetString(this byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            if (array != null)
                foreach (var item in array)
                {
                    sb.Append(String.Format("{0,4}", item));
                }

            return sb.ToString();
        }
    }
}

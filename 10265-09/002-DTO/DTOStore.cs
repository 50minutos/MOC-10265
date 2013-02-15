using System;
using System.Collections;

namespace _002_DTO
{
    public class DTOStore<T>
    {
        private static Hashtable ht;
        private static readonly object o;
        public static int I { get; set; }

        public static DTOStore<T> Entidade
        {
            get
            {
                lock (o)
                {
                    return new DTOStore<T>();
                }
            }
        }

        static DTOStore()
        {
            ht = Hashtable.Synchronized(new Hashtable()); 
            o = new Object();
            I = -1;
        }

        public IDTO<T> CriarDTO()
        {
            IDTO<T> dto = new DTO<T>();

            return dto;
        }

        public IDTO<T> ObterDTO(int chave)
        {
            lock (ht.SyncRoot)
            {
                if (ht.ContainsKey(chave))
                    return (IDTO<T>)ht[chave];
            }

            return null;
        }

        public bool AdicionarDTO(IDTO<T> dto)
        {
            if (ht.ContainsKey(dto.GetHashCode())) return false;

            lock (ht.SyncRoot)
            {
                ht.Add(dto.GetHashCode(), dto);
                I = dto.GetHashCode();
            }

            return true;
        }

        public bool RemoverDTO(int chave)
        {
            if (!ht.ContainsKey(chave)) return false;

            lock (ht.SyncRoot)
            {
                ht.Remove(chave);
                I = -1;
            }

            return true;
        }
    }
}

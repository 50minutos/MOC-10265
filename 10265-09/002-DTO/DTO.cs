using System;

namespace _002_DTO
{
    [Serializable]
    public class DTO<T> : IDTO<T>
    {
        public T Entidade { get; set; }
    }
}

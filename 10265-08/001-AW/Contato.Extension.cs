using System;

namespace _001_AW
{
    partial class Contato
    {
        public bool ValidarSenha(String senha)
        {
            return Hashing.CreatePasswordHash(senha, PasswordSalt) == PasswordHash;
        }
    }
}

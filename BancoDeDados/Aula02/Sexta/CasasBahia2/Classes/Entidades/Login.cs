using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Classes.Entidades
{
    internal class Login
    {
        //Propriedades
        public int Id { get; protected set; }
        public string Usuario { get; protected set; }
        public string Senha { get; protected set; }
        public string Regra { get; protected set; }

        //Construtor
        public Login(string usuario, string senha, string regra)
        {
            Usuario = usuario;
            Senha = senha;
            Regra = regra;
        }
    }
}

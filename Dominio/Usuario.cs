﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{ 
    public abstract class Usuario
    {
        
        string mail;
        string password;

        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public Usuario()
        {

        }
         public Usuario(string mail, string password)
        {
            Mail = mail;
            Password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using CadastroProway.DataBase;

namespace CadastroProway.Services
{
    class cadastroCafe
    {
        public string message = "";
        public string Coffee(string cafe)
        {
            command comando = new command();
            this.message = comando.Coffee(cafe);
            return message;
        }

    }
}

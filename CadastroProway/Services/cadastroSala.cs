using CadastroProway.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProway.Services
{
    class cadastroSala
    {
        public string message = "";
        public string Room(string sala)
        {
            command comando = new command();
            this.message = comando.Room(sala);
            return message;
        }
    }
}

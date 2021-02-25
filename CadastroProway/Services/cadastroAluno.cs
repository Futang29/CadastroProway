using CadastroProway.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProway.Services
{
    class cadastroAluno
    {
        public string message = "";
        public string Student(string nome)
        {
            command comando = new command();
            this.message = comando.Student(nome);
            return message;
        }
    }
}

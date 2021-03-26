using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domínio.Classes
{
    public class Aluno : Entidade
    {
        public string nome { get; protected set; }

        public Aluno()
        {
        }

        public Aluno(string nome)
        {
            this.nome = nome;
        }
    }
}
